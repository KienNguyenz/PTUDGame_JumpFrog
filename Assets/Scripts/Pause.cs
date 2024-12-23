using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject PausePanel;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause1()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
