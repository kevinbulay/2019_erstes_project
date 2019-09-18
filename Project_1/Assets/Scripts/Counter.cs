using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

    int counter = 0;

    void OnGUI()
    {
        GUI.Label(new Rect(200, 200, 400, 100), "COUNTER: " + counter);
        {
        }
    }


    void Update ()
    {
    }
}
