using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntering : MonoBehaviour
{
    public Avalanche avalancheObject;
    public GameOver userInterfaceObject;
    // Make object for each danger sign

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator OnTriggerEnter(Collider gameObjectInformation) { //IEnumerator 
        if (gameObjectInformation.tag == "Player") {
            avalancheObject.onPlayerEnter();
            yield return new WaitForSeconds(10);
            Debug.Log("Starting UI");
            userInterfaceObject.LaunchUI();
        }
    }
}
