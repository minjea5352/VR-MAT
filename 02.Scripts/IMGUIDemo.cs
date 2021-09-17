using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUIDemo : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Label(new Rect(1200,740,1000,300), "VR MAT");

        if (GUI.Button(new Rect(500,740,1500,300), "START"))
        {
            Debug.Log("START Button On!");
        }
    }

}
