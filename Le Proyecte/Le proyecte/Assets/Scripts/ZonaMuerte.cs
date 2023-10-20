using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collisionMuerte)
    {
        print(name + " hizo colision con " + collisionMuerte.gameObject.name + "se ha caido del mapa");
        //hacer que se muera
    }
}
