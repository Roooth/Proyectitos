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
    public int saltoDoble = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Al atribuirle MiCuerpo le asigno el componente rigid body 2d a este personaje
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ComprobarPiso();

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
            if (Input.GetButtonDown("Jump"))
            {
                miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
            }

            miAnimador.SetFloat("Vel_Vert", velActualVert);
        }
    }

    void ComprobarPiso()
    {
        //Lanzo un rayo de colision hacia abajo desde la posicion del este objeto
       enPiso = Physics2D.Raycast(transform.position,Vector2.down,0.1f);
    }
}
