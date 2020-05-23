using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambiaTxt : MonoBehaviour
{
    public Text txt;
    private string tiempo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        if (Time.time >=3)
        {
            txt.text = "f(x)=2X    f'(x)=?";
        }
       // tiempo = Time.time.ToString();
        
    }
}
