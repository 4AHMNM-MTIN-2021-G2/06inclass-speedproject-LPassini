using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomValue : MonoBehaviour
{
    public float Number;
    public Text Value;


    public void ValueButton()
    {
        Number = UnityEngine.Random.value;
        Value.text = Number.ToString();
        Debug.Log("Ich werde gedrückt");
    }
}
