using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesoroMoneda : MonoBehaviour
{
    public Personaje heroe;
    private Rigidbody2D dinero;
    
    // Start is called before the first frame update
    void Start()
    {
        dinero = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.CompareTag("Player")) //Si lo toca el jugador, destruir la moneda
        {
            Personaje.monedas++;
            dinero.AddForce(new Vector3(0, 3, 0), ForceMode2D.Impulse);
            dinero.AddForce(new Vector3(0, -1, 0), ForceMode2D.Impulse);
            Invoke("Destruir", 1);
        }
    }
    public void Destruir() 
    {
        Destroy(this.gameObject);
    }
}
