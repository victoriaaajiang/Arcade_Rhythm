using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public AudioSource mySounds;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    
    void OnMouseDown()
    {
        mySounds.PlayOneShot(hoverSound);
        mySounds.PlayOneShot(clickSound);
    }
    
}

