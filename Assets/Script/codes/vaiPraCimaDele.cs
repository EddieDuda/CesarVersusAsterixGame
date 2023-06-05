using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaiPraCimaDele : MonoBehaviour
{
    private GameObject inimigo;
    public float velocidade;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    void Update()
    {
        inimigo = GameObject.Find("inimigo1(Clone)");//procurando na cena o gameobject chamado de inimigo1(Clone)
        if (inimigo != null)
        {
            Vector2 posicaoInimigo = this.inimigo.transform.position;//pegando a posição do jogador
            Vector2 posicao = this.transform.position;//pegando a posição atual do gameoject
            Vector2 rota = posicaoInimigo - posicao;//calculado a distancia
            rota = rota.normalized;//normalizando o valor da distancia

            this.rb.velocity = (this.velocidade * rota);//velocidade de mmovimento

            //fazer o sprite virar pro lado que ta andando
            if (this.rb.velocity.x < 0)
            {

                this.sr.flipX = false;

            }
            else { this.sr.flipX = true; }
        }

    }
}