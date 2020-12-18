using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChartReset : MonoBehaviour
{
    public void Clear()
    {
        var fields = FindObjectsOfType<InputField>();
        foreach (var field in fields)
        {
            field.text = "";
        }
    }
}
