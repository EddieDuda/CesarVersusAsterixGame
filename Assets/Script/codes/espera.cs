using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espera : MonoBehaviour
{
    private float tempoDeEspera = 2; //tempo de espera pra usar a tropa
    private float proximaInvocacao = 0; //proxima vez que vai poder usar a tropa
    public GameObject aliado; //tropa

    void Update()
    {
        if (Time.time > proximaInvocacao) //se o tempo de jogo for maior que o tempo da proxima invocação 
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                var invocar = Instantiate(aliado, this.gameObject.transform).transform; //invocando as tropas
                proximaInvocacao = Time.time + tempoDeEspera; //calculo do cooldown
            }
        }
    }

}
