using UnityEngine;
using UnityEngine.UI;
public class OpenSettings : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel1;
    public GameObject panel1Text;
    private void Start()
    {
        panel.SetActive(false);
        panel1.SetActive(false);
    }

    public void Unhide()
    {
        panel.SetActive(true);
    }

    public void UnhideMainPanel()
    {
        panel1.SetActive(true);
    }



    public void Hide()
    {
        panel.SetActive(false);
    }

}
