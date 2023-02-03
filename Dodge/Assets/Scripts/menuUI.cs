using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
//Assigned to Canvas
// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class menuUI : MonoBehaviour
{
    public TMPro.TMP_InputField userNameInput;
    public Button startButton;


    public void StartNew()
    {
        SceneManager.LoadScene(1);
     }

    public void setUserName()
    {
        string userName = "Test";

        userName = userNameInput.text;
        sceneManager.Instance.userNameInput = userName;

    }

}
