using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vida : MonoBehaviour
{
    public int vidaAtual = 3;

    private GameManager.SceneType currentSceneType;

    private void Start()
    {
        currentSceneType = GameManager.Instance.GetSceneType(SceneManager.GetActiveScene().name);
        GameManager.Instance.SetPlayerLife(vidaAtual);
    }

    public void apanhou()
    {
        vidaAtual--;
        GameManager.Instance.SetPlayerLife(vidaAtual);

        if (vidaAtual <= 0)
        {
            if (currentSceneType == GameManager.SceneType.RomeLevel)
            {
                SceneManager.LoadScene("DerrotaAsterix");
            }
            else if (currentSceneType == GameManager.SceneType.GaliaLevel)
            {
                SceneManager.LoadScene("DerrotaCesar");
            }

            Destroy(gameObject);
        }
    }
}
