using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saindoPraBatalha : MonoBehaviour
{
    public GameObject inimigoPrefab;
    public float intialDelay;
    public float enemyPeriod;

    void Start()
    {
       InvokeRepeating("CreateEnemy",intialDelay,enemyPeriod); //invocando inimigo
    }

    void CreateEnemy()//variavel de invocação
   {
         var invocar = Instantiate(inimigoPrefab, this.gameObject.transform).transform;
   }
}

