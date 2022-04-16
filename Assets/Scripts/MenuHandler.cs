using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject optionPanel;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Sandbox");
    }

    public void showOptionsPanel()
    {
        optionPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void showMainPanel()
    {
        mainPanel.SetActive(true);
        optionPanel.SetActive(false);
    }
}
