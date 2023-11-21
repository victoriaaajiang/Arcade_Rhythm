using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public SpriteRenderer square;
    public Color newColor;
   

    void Start()
    {
        square = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
    }
    
    private void OnMouseDown()
    {
        square.color = newColor;
        mySounds().PlayOneShot(hoverSound);
        mySounds().PlayOneShot(clickSound);
    }
}


