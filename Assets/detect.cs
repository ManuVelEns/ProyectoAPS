using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Muro 2" || col.gameObject.name == "Muro")
        {
            transform.position = new Vector3(0, 1.5f, 27);
        }
    }
}
