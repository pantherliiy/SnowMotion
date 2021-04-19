using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class route_selection : MonoBehaviour
{
    public GameObject background, infoText, pointOfInterest;
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
