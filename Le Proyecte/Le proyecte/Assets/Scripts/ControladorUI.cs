using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{
    public Personaje heroe;
    public Text etiquetaHeroe;
    public Image barraHPHeroe;
    public Text scoreTexto;
    public Text vidasTexto;
    public Text moneda;
    public Image gameover;


    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        etiquetaHeroe.text = heroe.hp + "/" + heroe.hpMax;
        float porcentajeHP = heroe.hp / (float)heroe.hpMax;
        barraHPHeroe.fillAmount = porcentajeHP;
        scoreTexto.text = "Score: " + heroe.score;
        vidasTexto.text = "X " + Personaje.vidas;
        if (Personaje.vidas == 0)
        {
            bool vidasPerso = heroe.estaMuerto;
            gameover.fillAmount = 1;
        }

        //Monedas recojidas
        moneda.text = "$ = " + Personaje.monedas;


        //si mi personaje se quedo sin hp

        //si mi personaje se quedo sin vidas

    }
}
