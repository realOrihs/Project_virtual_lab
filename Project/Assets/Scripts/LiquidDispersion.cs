using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiquidDispersion : MonoBehaviour
{
    public Image liquid;
    public Image voda;
    private bool marker = false;
    public Text testText;

    public void VentelOpen()
    {
        if (marker == false)
        {
            marker = true;
            StartCoroutine(dispersionProcess());
        }
        else
        {
            marker = false;
        }
    }
    private IEnumerator dispersionProcess()
    {
        testText.text = Time.deltaTime.ToString();
        while ((liquid.fillAmount != 0 || voda.fillAmount != 0) && (marker))
        {
            liquid.fillAmount -= Time.deltaTime / 60;
            voda.fillAmount -= Time.deltaTime / 12;
            yield return null;
        }
    }
}
