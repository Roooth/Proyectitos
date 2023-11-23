using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personaje : MonoBehaviour
    
{
    // Start is called before the first frame update
    public int hp = 90;
    public int hpMax = 100;
    public int score = 0;
    public static int vidas = 3;
    public static int monedas = 0;
    public GameObject efectoSangrePrefab;
    private GameObject heroe;
    private Animator miAnimadori;
    private ReproductoSonidos misSonido;
    public bool aturdido = false;
    public bool estaMuerto = false;
    //agregar etique para vidas, ya tenemos la cosa aqui ahora en el contolador de ui hacer lo mismo que el score
    void Start()
    {
        miAnimadori = GetComponent<Animator>();
        misSonido = GetComponent<ReproductoSonidos>();
        heroe = GameObject.FindWithTag("Player");
    }

    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + "recibe daño de " + puntos + "por " + atacante.name);
        hp = hp - puntos;
        miAnimadori.SetTrigger("Ouch");
        misSonido.reproducir("DANIO");
        aturdido = true;
        Invoke("desaturdir", 1);
        if (hp <= 0) //Si lo que recibe daño muere...
        {
            estaMuerto = true;
            miAnimadori.SetBool("semurio", true);           
            Invoke("matar", 2);
            if (tag == "Player") //Si muere el jugador, reinicia el nivel
            {
                Invoke("Reiniciar", 10);
            }
        }
        else
        {
            estaMuerto = false;
            miAnimadori.SetBool("semurio", false);
        }

        


        //Creo instancia para prticula de sangre
        GameObject sangre = Instantiate(efectoSangrePrefab, transform);
    }
    private void desaturdir()
    {
        aturdido = false;
    }
    public void matar(int desvivir,GameObject atacante)
    {
        hp = 0;
        vidas = vidas - 1;
        misSonido.reproducir("MORIR");
        estaMuerto = true;
        print(name + " se murio");
        miAnimadori.SetBool("semurio", true);
    }

    public void Curar()
    {
        //curar 10 puntos de vida
        hp = hp + 10;
    }

    public void Envenenar()
    {
        //cada segundo daña x cantidad al jugador
        InvokeRepeating("hacerDanio", 3, 2);

    }



    private void Reiniciar () //Meodo para reiniciar escena xd
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (hp <= 0 && (Input.GetButtonDown("Fire1")))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            vidas = 3;
            monedas = 0;
            score = 0;
        }
    }
}
//Cosas a reparar el enemigo reinici el nivel, las vidas del ui se erinician y otros enemigos necesitan el script de sonido, animaciones y transiciones