using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPequenio : MonoBehaviour
{
    private float distanciaAgro = 5;
    private GameObject heroe;
    private Rigidbody2D miCuerpo;
    public float velocidadCaminar = 3;
    private Animator miAnimador;
    public int puntosDanio = 10;
    private Personaje miPersonaje;
    void Start()
    {
        heroe = GameObject.FindWithTag("Player");
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        miPersonaje = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posHeroe = heroe.transform.position;
        Vector3 posYo = this.transform.position;

        float distancia = (posYo - posHeroe).magnitude;
        if (distancia < distanciaAgro && !miPersonaje.aturdido && !miPersonaje.estaMuerto)
        {
            //Esta dentro de la distancia agro
            if (posHeroe.x > posYo.x)
            {
                //el heroe esta a la derecha del villano
                transform.rotation = Quaternion.Euler(0, 0, 0);
                miCuerpo.velocity = new Vector3(velocidadCaminar, 0, 0);
                miAnimador.SetBool("Caminandu", true);
            }
            else
            {
                //el heroe esta a la izaquierdaç
                transform.rotation = Quaternion.Euler(0, 180, 0);
                miCuerpo.velocity = new Vector3(-velocidadCaminar, 0, 0);
                miAnimador.SetBool("Caminandu", true);
            }
        }
        else
        {
            //el heroe esta fuera de la distancia agro
            miAnimador.SetBool("Caminandu", false);

        }
        if (miPersonaje.estaMuerto)
        { miAnimador.SetBool("semurio", true);
            
        }

        if (miPersonaje.aturdido)
        { miAnimador.SetTrigger("stun"); }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + " hizo colision con " + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            Personaje elPerso = otro.GetComponent<Personaje>();

            elPerso.hacerDanio(puntosDanio, this.gameObject);
        }
    }
}
