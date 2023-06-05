using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espera2 : MonoBehaviour
{
    private float tempoDeEspera2 = 6; //tempo de espera pra usar a tropa
    private float proximaInvocacao2 = 0; //proxima vez que vai poder usar a tropa
    public GameObject aliado; //tropa

    void Update()
    {
        if (Time.time > proximaInvocacao2) //se o tempo de jogo for maior que o tempo da proxima invocação 
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                var invocar = Instantiate(aliado, this.gameObject.transform).transform; //invocando as tropas
                proximaInvocacao2 = Time.time + tempoDeEspera2; //calculo do cooldown
            }
            
        }
    }
}
