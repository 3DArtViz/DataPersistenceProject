using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private InputField inputField;
    
    private string playerName;


    public void Start()
    {
        inputField.GetComponent<InputField>();   
        playerName = inputField.text;
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        
    }

    public void CheckOutPlayerName()
    {
        print(playerName);
    }
}
