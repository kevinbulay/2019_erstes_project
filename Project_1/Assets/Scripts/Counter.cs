using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

      int counter = 0;

        void OnGUI()
        {
            GUI.Label(new Rect(100, 100, 200, 50), "COUNTER: " + counter);
            {
            }
        }
        
    void OnMouseOver()
    {

    }

    void OnMouseExit()
    {
        counter++;
    }
}
