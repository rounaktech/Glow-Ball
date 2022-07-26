using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool pause = false;
    public void pausegame()
    {
        if(pause)
        {
            Time.timeScale = 1;
            pause = false;
        }
        else 
        {
            Time.timeScale = 0;
            pause = true;
        
        }
    }
}
