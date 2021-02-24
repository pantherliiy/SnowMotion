using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameObject.Start");
        GameObject myGameObject = new GameObject("MyNewGameObject", typeof(SpriteRenderer));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
