using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    private float distanciaInter = 3;
    private GameObject heroe;
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    public bool abierto = false;
    private Personaje miPersonaje;
    // Start is called before the first frame update
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

    }
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.CompareTag("Player")) //Si lo toca el jugador
        {
            Vector3 posHeroe = heroe.transform.position; //que esta mal, esto muestra el boton y una vez presiones ese y estes tocando el cofre se abre, mala interpretacion
            Vector3 posYo = this.transform.position;

            float distancia = (posYo - posHeroe).magnitude;
            if (distancia < distanciaInter && !miPersonaje.aturdido && !miPersonaje.estaMuerto && (Input.GetButtonDown("Fire1")))
            {

                miAnimador.SetBool("Abrir", true);
                abierto = true;
            }
            else
            {
                //el heroe esta fuera de la distancia agro
                miAnimador.SetBool("Abrir", false);
                abierto = false;
            }
        }
        
    }
}
