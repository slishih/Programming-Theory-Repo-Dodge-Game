using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

//Applied to empty Obj sceneManager
//Have Start Button call Start New when Clicked
//Have Input when Edited call get user name
public class sceneManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static sceneManager Instance { get; private set; }

    public string userNameInput; // new variable declared

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }


}
