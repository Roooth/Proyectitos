using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velozpor3s : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.CompareTag("Player")) //Si lo toca el jugador, destruir la moneda
        {
            ControladorJugador elPerso = otro.GetComponent<ControladorJugador>();
            elPerso.InvokeRepeating("Veloz", 3, 2);
            Invoke("Destruir", 3);
        }
    }
    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}
