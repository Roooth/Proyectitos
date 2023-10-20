using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZonaMuerte : MonoBehaviour
{
    public GameObject efectoAguaPrefab;
    public int vidaPerdida = 1;
    private void OnTriggerEnter2D(Collider2D trigger)
    {
       
        print(name + " hizo colision con " + trigger.gameObject.name + "se ha caido del mapa");
        //hacer que se muera y pierda la vida
        GameObject otra = trigger.gameObject;
        if (otra.tag == "Player")
        {
            Personaje elPerso = otra.GetComponent<Personaje>();

            elPerso.matar(vidaPerdida,this.gameObject);

            GameObject agua = Instantiate(efectoAguaPrefab, elPerso.transform);
        }

    }
    
}
