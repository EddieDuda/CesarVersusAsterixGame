using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaTropas : MonoBehaviour
{   
    //determinando a quantidade de vida das tropas
    private int vidaAtualNvl2 = 2;
    private int vidaAtualNvl3 = 3;

    public void golpeado()
    {
        //diminuindo a vida das tropas
        if(gameObject.CompareTag("nvl2"))
        {
           vidaAtualNvl2 = vidaAtualNvl2 - 1;
            if(vidaAtualNvl2 <= 0)
            {

                Destroy(gameObject);

            } 
        }
        else if(gameObject.CompareTag("nvl3"))
        {
           vidaAtualNvl3 = vidaAtualNvl3 - 1;
            if(vidaAtualNvl3 <= 0)
            {

                Destroy(gameObject);

            } 
        }
        else
        {
            Destroy(gameObject);
        }
            
    }
}