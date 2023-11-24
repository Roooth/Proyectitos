using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    private GameObject heroe;
    // Start is called before the first frame update
    void Start()
    {
        heroe = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (heroe)
        {
            //si se muere el jugador reinicia la escena
        }
    }
}
