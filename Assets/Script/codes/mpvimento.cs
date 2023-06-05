using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mpvimento : MonoBehaviour
{
    
    public float velocidade;
    private Rigidbody2D rigi;
    public SpriteRenderer sr;

    void Start()
    {
        rigi = GetComponent<Rigidbody2D>(); //pegando o Rigidbody2D
    }

    void Update()
    {
        Vector2 Position = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical")); //pegando o imput dos botões de movimentação
        rigi.velocity = Position * velocidade;  //velocidade de movimento 

        //fazer o sprite virar pro lado que ta andando
        if (this.rigi.velocity.x < 0)
        {

            this.sr.flipX = false;

        }
        else{this.sr.flipX = true;}
    }
}
