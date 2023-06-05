using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espera3 : MonoBehaviour
{
    private float tempoDeEspera3 = 10; //tempo de espera pra usar a tropa
    private float proximaInvocacao3 = 0; //proxima vez que vai poder usar a tropa
    public GameObject aliado; //tropa

    void Update()
    {
        if (Time.time > proximaInvocacao3) //se o tempo de jogo for maior que o tempo da proxima invocação 
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                var invocar = Instantiate(aliado, this.gameObject.transform).transform; //invocando as tropas
                proximaInvocacao3 = Time.time + tempoDeEspera3; //calculo do cooldown
            }
            
        }
    }
}
