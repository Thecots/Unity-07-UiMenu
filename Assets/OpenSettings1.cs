using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings1 : MonoBehaviour
{
    public Color defaultColor;
    public GameObject panel1;
    public GameObject panel2;

    public Camera cam;

    public void restart()
    {
        cam.backgroundColor = defaultColor;
    }

    public void closeAll()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
    }
}
