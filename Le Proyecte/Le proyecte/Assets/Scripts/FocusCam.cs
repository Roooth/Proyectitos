using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCam : MonoBehaviour
 
{
    public Transform Cavernicola;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Cavernicola.position.x, Cavernicola.position.y, -1);
    }
}
