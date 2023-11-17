using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesoroMoneda : MonoBehaviour
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


    }
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.CompareTag("Player")) //Si lo toca el jugador, destruir la moneda
        {
           
            Destroy(this.gameObject);
        }
    }

}
