using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneActivator : MonoBehaviour
{
    public GameObject phoneObject;
    // public bool isPhoneShown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
      if (Input.GetKeyDown(KeyCode.M)) {
            MeshRenderer phone = phoneObject.GetComponent<MeshRenderer> ();
            phone.enabled = !phone.enabled;
        }   
    }
}