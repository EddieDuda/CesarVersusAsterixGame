using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DerrotaCesarController : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene("Menu");
    }
}
