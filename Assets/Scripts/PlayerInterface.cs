using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInterface : MonoBehaviour
{
    public Toggle Player;
    public Toggle Narrator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NarratorInterface()
    {
        if (Narrator.isOn) { 
        SceneManager.LoadScene("NarratorScene");
        }
    }

    public void JoueurInterface()
    {
        if (Player.isOn) {
        SceneManager.LoadScene("PlayerScene");
        }
    }
}
