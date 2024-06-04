using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Button button;
    private void Start()
    {
        //button starts detecting if clicked
        button = GetComponent<Button>();
        button.onClick.AddListener(clicked);
    }
    private void clicked()
    {
        //when clicked, load game scene
        SceneManager.LoadScene("FinalProjectScene");
    }
}
