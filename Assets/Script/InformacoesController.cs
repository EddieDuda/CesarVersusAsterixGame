using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InformacoesController : MonoBehaviour
{
    public void Voltar()
    {
        SceneManager.LoadScene("Menu");
    }
}