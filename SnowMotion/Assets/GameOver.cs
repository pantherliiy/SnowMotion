using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

public class GameOver : MonoBehaviour
{
    public GameObject header;
    public GameObject header_subtext;
    public GameObject steep_ski;
    public GameObject gentle_ski;
    public GameObject steep_uphill;
    //public GameObject WalkUpObject; Trigger for choice of path up
    //public GameObject SkiDownObject; Trigger for choice of path down
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        
    }

    public void LaunchUI() { //Change to last in main
        if (gentle_ski.GetComponent<gentleSki>().gentle_chosen) {
            header.GetComponent<UnityEngine.UI.Text>().text = "Du unngikk snøskredet";
            header_subtext.GetComponent<UnityEngine.UI.Text>().text = "Du kjente igjen faretegnene under og valgte å kjøre den slake bakken for å unngå snøskredet. Bra jobba!"; 
        } else if (steep_ski.GetComponent<steepski>().steep_chosen) {
            header.GetComponent<UnityEngine.UI.Text>().text = "Du utløste et stort skred!";
            header_subtext.GetComponent<UnityEngine.UI.Text>().text = "Du valgte å kjøre ned den bratte bakken og utløste derfor et større skred. Se under for faretegnene du må legge mer merke til neste gang.";
        }
        gameObject.GetComponent<Canvas> ().enabled = true;   
    }

    public void LaunchFirstUI() {  //UI possible triggered if user walks up steep hill instead of safe way around 
        if (steep_uphill.GetComponent<avalancheTriggerWithEndScreen>().steep_uphill_chosen) {
            header.GetComponent<UnityEngine.UI.Text>().text = "Du utløste et stort skred!";
            header_subtext.GetComponent<UnityEngine.UI.Text>().text = "Du valgte å gå opp den bratte bakken og utløste derfor et større skred. Se under for faretegnene du må legge mer merke til neste gang.";
            gameObject.GetComponent<Canvas> ().enabled = true;
        }
    }

    public void hideUI() {
        Debug.Log("button clicked");
        gameObject.GetComponent<Canvas> ().enabled = false;   
    }
}