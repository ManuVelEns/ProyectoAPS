using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cambiaEsc : MonoBehaviour
{

    public void change(int escena1)
    {
        SceneManager.LoadScene(escena1);
    }

    public void quit()
    {
        
        Application.Quit();
    }
}
