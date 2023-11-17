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
    private Personaje miPersonaje;
    private void Start()
    {
        miPersonaje = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        etiquetaHeroe.text = heroe.hp + "/" + heroe.hpMax;
        float porcentajeHP = heroe.hp / (float)heroe.hpMax;
        barraHPHeroe.fillAmount = porcentajeHP;
        scoreTexto.text = "Score: " + heroe.score;
        vidasTexto.text = "X " + heroe.vidas;

        //Monedas recojidas
        moneda.text = "$ = " + heroe.monedas;

        //si mi personaje se quedo sin hp

        //si mi personaje se quedo sin vidas
        
    }
}
