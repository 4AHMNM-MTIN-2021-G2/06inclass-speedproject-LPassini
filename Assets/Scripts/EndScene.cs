﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public Data data;
    public Text name;
    public Text randValueTxt;
    public Text time;
    public Text message;
    void Start()
    {
        name.text = data.name;
        randValueTxt.text = data.randomVal.ToString("f2");
        time.text = data.time.ToString("f2");

        float timeTmp = data.time;
        if (timeTmp < 3)
        {
            message.text = "Das war super!";
        }
        else if (timeTmp < 6)
        {
            message.text = "Das war fast zu langsam.";
        }
        else
        {
            message.text = "Das war zu langsam!";
        }

    }

    public void ResetScene()
    {
        data.name = "";
        data.randomVal = 0;
        data.time = 0;
        SceneManager.LoadScene("Intro");
    }

}