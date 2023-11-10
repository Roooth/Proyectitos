using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    private Rigidbody2D miCuerpo;
    public float velocidadCaminar = 3;
    public float fuerzaSalto = 0; //Esta variable es la que parametriza y sale en el inspector de unity xd
    private Animator miAnimador;
    public bool enPiso = false; //grounded
    public int saltoDoble = 0;//se puede saltar doble? o no
    public int maxSaltosPos = 2;//defino cuanto es el maximo de saltos posibles, 2 porque puede saltar desde el piso y uno en el aire
    private ReproductoSonidos misSonidos;
    public int puntosDanio = 5;
    private BoxCollider2D arma;

    // Start is called before the first frame update
    void Start()
    {
        //Al atribuirle MiCuerpo le asigno el componente rigid body 2d a este personaje
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductoSonidos>();
        arma = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ComprobarPiso();
        if (enPiso)
        {
            miAnimador.SetBool("EnPiso", true);
        }

        if (!enPiso)
        {
            miAnimador.SetBool("EnPiso", false);
        }

        float velActualVert = miCuerpo.velocity.y;
        //Leo si el usuario esta presionando un eje horizontal en las flechas
        float movHoriz = Input.GetAxis("Horizontal");
        if (movHoriz > 0)// A la derecha
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //El 3 es hardcore, asi es parametrizado :D
            miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);

        }
        else if (movHoriz < 0)//A la izquierda
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);

            miAnimador.SetBool("Caminando", true);

        }
        else//Quieto
        {
            miCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("Caminando", false);
        }


        //Salto
        if (enPiso)
        {
            saltoDoble = 0; //se resetea el si podemos hacer salto doble para que no saltemos infinitamnete
            if (Input.GetButtonDown("Jump"))
            {
                miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
                misSonidos.reproducir("SALTAR");
            }

            if (Input.GetButtonDown("Fire1"))
            {
                //Atacar


                miAnimador.SetFloat("Vel_Vert", velActualVert);


            }

            else if (Input.GetButtonDown("Jump") && saltoDoble < maxSaltosPos - 1) //si se salta y ya se reseteo el salto doble..
            {
                miCuerpo.AddForce(new Vector2(0, fuerzaSalto), ForceMode2D.Impulse);//salta xd
                saltoDoble++;//decir que ya se hizo el salto doble xd
                misSonidos.reproducir("SALTAR");
            }
        }
    
       

        void ComprobarPiso()
        {
            //Lanzo un rayo de colision hacia abajo desde la posicion del este objeto
            enPiso = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
        }
    }

    private void OnTriggerEnter2D(BoxCollider2D arma)
    {
        GameObject otro = arma.gameObject;
        if (otro.tag == "Enemigo")
        {
            Personaje elPerso = otro.GetComponent<Personaje>();

            elPerso.hacerDanio(puntosDanio, otro.gameObject);
            print(name + " hizo colision con " + arma.gameObject.name + "se murio el enemigo");
        }
        miAnimador.SetTrigger("Atacar");
    }
}
