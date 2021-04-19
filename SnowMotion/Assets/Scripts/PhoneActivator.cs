using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneActivator : MonoBehaviour
{
    public GameObject weather_phone;
    public GameObject varsom_phone;

    // public bool isPhoneShown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
      if (Input.GetKeyDown(KeyCode.B)) {
        MeshRenderer weather_render = weather_phone.GetComponent<MeshRenderer> ();
        MeshRenderer varsom_render = varsom_phone.GetComponent<MeshRenderer> ();

        varsom_render.enabled = false;
        weather_render.enabled = !weather_render.enabled;
      }
        
      if (Input.GetKeyDown(KeyCode.V)) {
        MeshRenderer varsom_render = varsom_phone.GetComponent<MeshRenderer> ();
        MeshRenderer weather_render = weather_phone.GetComponent<MeshRenderer> ();
        
        weather_render.enabled = false;
        varsom_render.enabled = !varsom_render.enabled;
      }
    }
}