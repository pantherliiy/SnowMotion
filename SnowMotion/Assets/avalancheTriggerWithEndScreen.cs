using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avalancheTriggerWithEndScreen : MonoBehaviour
{
    public Avalanche avalancheObject;
    public GameOver userInterfaceObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator  OnTriggerEnter(Collider gameObjectInformation) { //IEnumerator 
        avalancheObject.onPlayerEnter();
        yield return new WaitForSeconds(15);
        userInterfaceObject.LaunchUI();
    }

    private void OnTriggerExit(Collider other){
  
    }
}
