using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject ContactUsWindow;
    public GameObject CreateNewWindow;
    public GameObject PlayerOrNarrator;
    public GameObject SettingsMenu;
    public GameObject InfosMenu;
    public GameObject MainMenu;
    public GameObject MainGame;
    public GameObject SettingsInterface;
    public GameObject VolumeOn;
    public GameObject VolumeOff;
  
    public void LoadOptionsScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("NarratorScene");
    }

    public void BackScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    

    public void BackMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Settings()
    {
        SettingsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void Infos()
    {
        InfosMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void SettingsInt()
    {
        SettingsInterface.SetActive(true);
        MainGame.SetActive(false);
    }
    public void ContactUS()
    {
        ContactUsWindow.SetActive(true);
    }

    public void NewPlayer()
    {
        CreateNewWindow.SetActive(true);
    }

    public void PLayer()
    {
        PlayerOrNarrator.SetActive(true);
    }

    public void VolumeDisable()
    {
        VolumeOff.SetActive(false);
        VolumeOn.SetActive(true);
    }
     public void VolumeEnable()
    {
        VolumeOn.SetActive(true);
        VolumeOff.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
