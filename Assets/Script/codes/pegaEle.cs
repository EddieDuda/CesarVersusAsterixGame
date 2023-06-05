using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegaEle : MonoBehaviour
{
    public GameObject Aliado;
    public float velocidade;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    // Update is called once per frame
    void Update()
    {
        Aliado = GameObject.Find("jogador");//procurando na cena o gameobject chamado de jogador

        Vector2 posicaoAliado = this.Aliado.transform.position; //pegando a posição do jogador
        Vector2 posicao = this.transform.position;//pegando a posição atual do gameoject
        Vector2 rota = posicaoAliado - posicao;//calculado a distancia
        rota = rota.normalized;//normalizando o valor da distancia

        this.rb.velocity = (this.velocidade * rota);//velocidade de mmovimento

        //fazer o sprite virar pro lado que ta andando
        if (this.rb.velocity.x < 0)
        {

            this.sr.flipX = false;

        }
        else{this.sr.flipX = true;}
    }
}
