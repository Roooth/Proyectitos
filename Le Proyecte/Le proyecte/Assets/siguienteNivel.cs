using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class siguienteNivel : MonoBehaviour
{
    public GameObject efectoFestejo;
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
        if (otro.gameObject.CompareTag("Player")) //Si lo toca el jugador
        {
            GameObject Fiesta = Instantiate(efectoFestejo, transform);
            GameObject Fiesta1 = Instantiate(efectoFestejo, transform);
            GameObject Fiesta2 = Instantiate(efectoFestejo, transform);
            GameObject Fiesta3 = Instantiate(efectoFestejo, transform);
            Invoke("Nivel2", 1);
        }
    }
    private void Nivel2()
    {
        SceneManager.LoadScene(4);
    }
}
