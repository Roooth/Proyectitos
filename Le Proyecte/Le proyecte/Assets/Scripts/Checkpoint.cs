using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Vector3 respawnPoint;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.CompareTag("Player")) //Si lo toca el jugador
        {
            print("Tocaron el checkpoint");
            Personaje elPerso = otro.GetComponent<Personaje>();
            if (elPerso.hp == 0)
            {
                
            }
            Invoke("Reiniciar", 3);
        }
    }
}
