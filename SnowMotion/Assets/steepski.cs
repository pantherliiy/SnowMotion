using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steepski : MonoBehaviour
{

    public Avalanche firstAvalancheObject;
    public Avalanche secondAvalancheObject;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController player;
    public AudioSource audioData;
    public bool steep_chosen = false;

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
            steep_chosen = true;
            firstAvalancheObject.onPlayerEnter();
            secondAvalancheObject.onPlayerEnter();
            player.isSliding = true;
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            // yield return new WaitForSeconds(10);
            // Debug.Log("Starting UI");
            // userInterfaceObject.LaunchUI();
        }
    }

}
