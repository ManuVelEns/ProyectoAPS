﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    bool pausa = false;


    public void pausar()
    {
        if (!pausa)
        {
            pausa = true;
            Time.timeScale = 0;
           
        }
        else
        {
            pausa = false;
            Time.timeScale = 1; 
        }
      
    }
    

}
