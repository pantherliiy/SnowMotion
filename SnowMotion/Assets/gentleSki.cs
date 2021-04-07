using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gentleSki : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController player;
    public AudioSource audioData;
    public bool gentle_chosen = false;
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
            gentle_chosen = true;
            Debug.Log("gentle ski");
            player.isSliding = true;
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            // yield return new WaitForSeconds(10);
            // Debug.Log("Starting UI");
            // userInterfaceObject.LaunchUI();
        }
    }
}
