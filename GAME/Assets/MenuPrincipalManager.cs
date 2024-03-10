 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{

    [SerializeField] private string sceneOfTheGame;
    [SerializeField] private GameObject painelInitialMenu;
    [SerializeField] private GameObject painelOptions;

    public void Play()
    {
        SceneManager.LoadScene(sceneOfTheGame);
    }

    public void ShowOptions()
    {
        painelInitialMenu.SetActive(false);
        painelOptions.SetActive(true);
    }

    public void CloseOptions()
    {
        painelOptions.SetActive(false);
        painelInitialMenu.SetActive(true);
        
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }


}
