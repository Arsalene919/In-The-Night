using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string PlayerName;
    public string PlayerRole;
    
    public void SavePlayer()
    {
        Save.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = Save.LoadPlayer();

        PlayerName = data.PlayerName;
        PlayerRole = data.PlayerRole;
        Debug.Log("hello");
    }
}
