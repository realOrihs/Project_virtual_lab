using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiquidChoiceManager : MonoBehaviour
{
    public List<GameObject> liquids;
    public LiquidDispersion mark;

    public void HandleInputData(int val)
    {
        foreach (var i in liquids)
        {
            i.SetActive(false);
        }
        liquids[val].SetActive(true);
        mark.liquid = liquids[val].GetComponent<Image>();
    }
}
