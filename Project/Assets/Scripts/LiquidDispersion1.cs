using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiquidDispersion1 : MonoBehaviour
{
    public Image jija;
    public Image voda;
    private bool marker = false;

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
        while ((jija.fillAmount != 0 || voda.fillAmount != 0) && (marker))
        {
            jija.fillAmount -= Time.deltaTime / 60;
            voda.fillAmount -= Time.deltaTime / 12;
            yield return null;
        }
    }
}