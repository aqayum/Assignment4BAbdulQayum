using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlingMainMenu : MonoBehaviour
{
    public GameObject panelofmainmenu;
    public GameObject panelofhummingbird;
    // Start is called before the first frame update
    void Start()
    {
        panelofmainmenu.SetActive(true);
    }
    public void Penguingame()
    {
        SceneManager.LoadScene("Penguins");
    }
    public void Hummingbirdmenu()
    {
        panelofhummingbird.SetActive(true);
        panelofmainmenu.SetActive(false);
    }
    public void MlAgent()
    {
        SceneManager.LoadScene("Training");
    }
    public void Battlewithmlagent()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
    public void gobacktmainpanel()
    {
        panelofmainmenu.SetActive(true);
        panelofhummingbird.SetActive(false);

    }

}
