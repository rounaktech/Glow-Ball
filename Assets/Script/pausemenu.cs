using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuui;
     
    
    bool pause = false;
    

    public void enablepausemenu()
    {
        if (pause == true)
        {
            Time.timeScale = 1;
            pause = false ;
            menuui.SetActive(false);

        }
        else
        {
            Time.timeScale = 0;
            pause = true;

            menuui.SetActive(true);
        }
    }
}
