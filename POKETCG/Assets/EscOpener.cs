using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscOpener : MonoBehaviour
{
    public GameObject panel;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            panel.SetActive(!panel.activeSelf);

    }
}
