using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    public void ChangeColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        Debug.Log("IT WORKS");
        renderer.material.SetColor("_Color", Color.red);

    }
        

}
