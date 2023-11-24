using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cofre : MonoBehaviour
{    
    public GameObject ItemDrop;
    private Animator miAnimador;
    public float delayCofre;
    public bool Abierto = false;

    public Text presionaTecla;
    
    void Start()
    {
        
        miAnimador = GetComponent<Animator>();
        presionaTecla.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D otro)
    {
        if (otro.gameObject.CompareTag("Player")) //Si lo toca el jugador
        {
            presionaTecla.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E) && !Abierto)
            {
                miAnimador.Play("abrir");
                StartCoroutine(GetChestItem());
            }
        }

        
    }

    private void OnTriggerExit2D(Collider2D otro)
    {
        if (otro.gameObject.CompareTag("Player")) //Si ya no lo toca el jugador
        {
            presionaTecla.gameObject.SetActive(false);
        }


    }

    IEnumerator GetChestItem()
    {
        yield return new WaitForSeconds(delayCofre);
        Instantiate(ItemDrop, transform.position, Quaternion.identity);
        Abierto = true;
        presionaTecla.gameObject.SetActive(false);
    }
}
