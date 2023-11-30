using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameControler gc;


    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GC").GetComponent<GameControler>();
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
            gc.lastCheckPointPos = transform.position;
        }
    }
}
