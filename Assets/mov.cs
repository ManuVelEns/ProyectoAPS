using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    private int move = 0;
    public float speed = 10.0F;
    private Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        posicion = new Vector3(0, 1.5f, 27);
    }
    // Update is called once per frame
    void Update()
    {   

        if(this.transform.position == posicion)
        {
            move = 0;
        }
        if (Input.touchCount > 0)
        {
            // Debug.Log(Input.touchCount);
            Touch touch = Input.GetTouch(0);
          if(touch.phase == TouchPhase.Began) { 
            Vector3 touchPosition = touch.position;
            //Debug.Log(transform.position);
            if(touchPosition.x > 1000 && (move == 0 || move == -1))
            {
                transform.Translate(8, 0, 0);
                   move++;     
            }
            if (touchPosition.x < 800 && (move == 0 || move ==1))
            {
                transform.Translate(-8, 0, 0);
                    move--;
                }
           }
        }
        
        transform.Translate(0, 0,  speed * Time.deltaTime);
        if (Input.GetKeyDown("d"))
        {
            transform.Translate(8, 0, 0);
        }
        if (Input.GetKeyDown("a"))
        {
            transform.Translate(-8, 0, 0);
        }
      
    }
}
