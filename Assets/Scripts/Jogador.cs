using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    // VARIÁVEIS
    public Transform limite_direita, limite_esquerda;
    public float velocidade; 
    public bool direita, mouse, barra_espaco; // TRUE OR FALSE
    public Rigidbody2D fisica;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mover();
        clicar();
    }

    private void clicar()
    {
        // IDENTIFICAR O CLICK DO MOUSE
        mouse = Input.GetMouseButtonDown(0);
        // IDENTIFICAR O APERTAR DA BARRA DE ESPAÇO
        barra_espaco = Input.GetKeyDown("space");

        if (mouse == true || barra_espaco == true)
        {
            // ALTERNAR VALOR DA VARIÁVEL BOLEANA
            direita = !direita;
        }

    }

    private void mover()
    {
        if(direita == true)
        {
            fisica.velocity = Vector2.right * velocidade * Time.deltaTime;
        }
        else
        {
            fisica.velocity = Vector2.left * velocidade * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Limite"))
        {
            direita = !direita;
        }
    }
}
