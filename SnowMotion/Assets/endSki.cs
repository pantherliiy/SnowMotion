using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endSki : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController player;
    public GameObject steepTrigger, gentleTrigger;
    private AudioSource audioDataSteep, audioDataGentle;
    public GameOver userInterfaceObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator OnTriggerEnter(Collider gameObjectInformation) { //IEnumerator 
        if (gameObjectInformation.tag == "Player" & (gentleTrigger.GetComponent<gentleSki>().gentle_chosen | steepTrigger.GetComponent<steepski>().steep_chosen)) {
            player.isSliding = false;
            audioDataSteep = steepTrigger.GetComponent<AudioSource>();
            audioDataSteep.Stop();
            audioDataGentle = gentleTrigger.GetComponent<AudioSource>();
            audioDataGentle.Stop();
            yield return new WaitForSeconds(5.0f);  
            userInterfaceObject.LaunchUI();
            // yield return new WaitForSeconds(10);
            // Debug.Log("Starting UI");
            // userInterfaceObject.LaunchUI();
        }
    }
}
