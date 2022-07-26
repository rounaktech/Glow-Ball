using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutUs : MonoBehaviour


{
    public void aboutus()
    {
        SceneManager.LoadScene(sceneName: "About Us");
    }
}

