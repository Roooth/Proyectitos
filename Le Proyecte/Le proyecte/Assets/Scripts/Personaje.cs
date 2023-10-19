using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
    
{
    // Start is called before the first frame update
    public int hp = 90;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 3;
    private Animator miAnimadori;
    //agregar etique para vidas, ya tenemos la cosa aqui ahora en el contolador de ui hacer lo mismo que el score
    void Start()
    {
        miAnimadori = GetComponent<Animator>();
    }

    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + "recibe daño de " + puntos + "por " + atacante.name);
        hp = hp - puntos;
        miAnimadori.SetTrigger("Ouch");
    }


    // Update is called once per frame
    void Update()
    {

    }
}
