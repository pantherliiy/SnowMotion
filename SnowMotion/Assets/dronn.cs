using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dronn : MonoBehaviour
{
    public AudioSource audioData;
    public GameObject background, infoText, pointOfInterest; 
    public bool isTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter(Collider other){
        if (!isTriggered) {
            isTriggered = true;
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
        SpriteRenderer pointOfInterestMesh = pointOfInterest.GetComponent<SpriteRenderer>();
        pointOfInterestMesh.enabled = !pointOfInterestMesh.enabled;

        yield return new WaitForSeconds(1);

        MeshRenderer backgroundMesh = background.GetComponent<MeshRenderer>();
        backgroundMesh.enabled = !backgroundMesh.enabled;

        MeshRenderer infoMesh = infoText.GetComponent<MeshRenderer>();
        infoMesh.enabled = !infoMesh.enabled;
    }

    private void OnTriggerExit(Collider other){
        SpriteRenderer pointOfInterestMesh = pointOfInterest.GetComponent<SpriteRenderer>();
        pointOfInterestMesh.enabled = !pointOfInterestMesh.enabled;

        MeshRenderer backgroundMesh = background.GetComponent<MeshRenderer>();
        backgroundMesh.enabled = !backgroundMesh.enabled;

        MeshRenderer infoMesh = infoText.GetComponent<MeshRenderer>();
        infoMesh.enabled = !infoMesh.enabled;
    }
}
