using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private int seconds;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private Movement controller;

    void Start()
    {
        //repeat function timerr
        InvokeRepeating("Timerr", 0, 1);
    }

    void Timerr()
    {
        //records seconds elapsed and displays them in ui
        seconds++;
        timerText.text = ("Time: " + seconds);
    }
}
