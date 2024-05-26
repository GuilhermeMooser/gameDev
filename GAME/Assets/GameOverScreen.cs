using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public void RestartButton()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        SceneManager.LoadScene("Main");
        Debug.Log("Main");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("InterfaceScene");
        Debug.Log("exit");
    }

}
