using UnityEngine;
public class BackgroundColor : MonoBehaviour
{
    public Camera cam;

    public Color redColor;
    public Color blueColor;
    public Color greenColor;


    public void red() {
        cam.backgroundColor = redColor;
    }

    public void blue()
    {
        cam.backgroundColor = blueColor;
    }

    public void green()
    {
        cam.backgroundColor = greenColor;
    }
}
