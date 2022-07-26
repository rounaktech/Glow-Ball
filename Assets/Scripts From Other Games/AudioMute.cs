using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioMute : MonoBehaviour
{
    public void mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
