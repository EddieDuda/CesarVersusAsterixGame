using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayAsCesar()
    {
        SceneManager.LoadScene("GaliaLevel");
    }

    public void PlayAsAsterix()
    {
        SceneManager.LoadScene("RomeLevel");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadInformacoesScene()
    {
        SceneManager.LoadScene("Informacoes");
    }
    
    public void LoadControlesScene()
    {
        SceneManager.LoadScene("Controles");
    }
}