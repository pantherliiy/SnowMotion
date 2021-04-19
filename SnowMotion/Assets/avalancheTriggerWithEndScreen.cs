using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avalancheTriggerWithEndScreen : MonoBehaviour
{
    public Avalanche avalancheObject1;
    public Avalanche avalancheObject2;
    public Avalanche avalancheObject3;
    public GameOver userInterfaceObject;
    public bool steep_uphill_chosen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator  OnTriggerEnter(Collider gameObjectInformation) { //IEnumerator 
        if (gameObjectInformation.tag == "Player") {
            steep_uphill_chosen = true;
            avalancheObject1.onPlayerEnter();
            avalancheObject2.onPlayerEnter();
            avalancheObject3.onPlayerEnter();
            yield return new WaitForSeconds(15);
            userInterfaceObject.LaunchFirstUI();
        }
    }

    private void OnTriggerExit(Collider other){
  
    }
}
