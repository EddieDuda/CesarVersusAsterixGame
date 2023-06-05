using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.CompareTag("Player")) //se colidir com um objeto com a tag player vai chamar o componente apanhou da classe vida
        {
            other.gameObject.GetComponent<vida>().apanhou();
        }
        else
        {
            other.gameObject.GetComponent<vidaTropas>().golpeado();//se não vai chamar o golpeado apanhou da classe vidaTropas
        }

        Destroy(gameObject);//vai se destruir apos colidir
        
    }

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    private void OnDestroy()
    {
        if (gameManager != null)
        {
            gameManager.AddPoints(1);
        }
    }
}
