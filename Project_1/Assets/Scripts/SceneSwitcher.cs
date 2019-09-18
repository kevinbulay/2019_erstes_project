using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour {

    public void LoadNextScene()
    {
        Application.LoadLevel("Scene1");
    }

    public void LoadPreviousScene()
    {
        Application.LoadLevel("Scene2");
    }
}
