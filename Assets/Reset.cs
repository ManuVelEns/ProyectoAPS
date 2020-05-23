using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject pj;
    // Start is called before the first frame update
   public void restar()
    {
        pj.transform.position = new Vector3(0, 1.5f, 27);
    }
}
