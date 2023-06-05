using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correuProQuartel : MonoBehaviour
{
    public float tempodevida;

    void Start()
    {
        Invoke("destruir", tempodevida);//invocando a autodestruição depois de um determinado tempo
    }


    //autodestruição
    void destruir(){
        Destroy(gameObject);
    }
}
