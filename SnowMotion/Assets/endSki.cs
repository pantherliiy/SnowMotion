using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endSki : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController player;
    public GameObject steepTrigger, gentleTrigger;
    private AudioSource audioDataSteep, audioDataGentle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider gameObjectInformation) { //IEnumerator 
        if (gameObjectInformation.tag == "Player") {
            player.isSliding = false;
            audioDataSteep = steepTrigger.GetComponent<AudioSource>();
            audioDataSteep.Stop();
            audioDataGentle = gentleTrigger.GetComponent<AudioSource>();
            audioDataGentle.Stop();
            // yield return new WaitForSeconds(10);
            // Debug.Log("Starting UI");
            // userInterfaceObject.LaunchUI();
        }
    }
}
