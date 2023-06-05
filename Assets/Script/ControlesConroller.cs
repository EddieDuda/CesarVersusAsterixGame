using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlesConroller : MonoBehaviour
{
    public void Voltar()
    {
        SceneManager.LoadScene("Menu");
    }
}
