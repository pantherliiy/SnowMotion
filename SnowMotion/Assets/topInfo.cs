using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topInfo : MonoBehaviour
{
    public GameObject background, infoText, pointOfInterest, steepSki, gentleSki ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        SpriteRenderer pointOfInterestMesh = pointOfInterest.GetComponent<SpriteRenderer>();
        pointOfInterestMesh.enabled = !pointOfInterestMesh.enabled;

        MeshRenderer backgroundMesh = background.GetComponent<MeshRenderer>();
        backgroundMesh.enabled = !backgroundMesh.enabled;

        MeshRenderer infoMesh = infoText.GetComponent<MeshRenderer>();
        infoMesh.enabled = !infoMesh.enabled;

        MeshRenderer steepSkiMesh = steepSki.GetComponent<MeshRenderer>();
        steepSkiMesh.enabled = true;

        MeshRenderer gentleSkiMesh = gentleSki.GetComponent<MeshRenderer>();
        gentleSkiMesh.enabled = true;
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
