using UnityEngine;
using System.Collections;
 
public class Avalanche : MonoBehaviour
{

    public GameObject avalancheRigidBody;
    public float avalancheSpeed = -30f;
    public float avalancheTopSpeed = 100f;
    public float avalancheStopSpeed = 0.5f;

    private float speed;
    private bool stoppedCheck = false;
    private bool avalancheStopped = false;
    private bool avalancheStart = false;

    public AudioSource avalancheStartAudio;
    public AudioSource avalancheMiddleAudio;
    public AudioSource avalancheEndAudio;

    //initialize values 
    void Start() 
	{

        Physics.gravity = new Vector3(0, avalancheSpeed, 0);
        avalancheRigidBody.GetComponent<Rigidbody>().maxAngularVelocity = avalancheTopSpeed;

        avalancheRigidBody.SetActive(false);

    } 

    public void onPlayerEnter () {
        if (AvalancheStartCheck.avalancheStart == false)
            {
                Debug.Log("Avalanch starting");
                StartCoroutine("StartAvalanche");
            }
    }
 
	void Update() 
	{
        // Check to see if the first avalanch snow particle has been emitted - used to sync up the sound
        if (AvalancheStartCheck.avalancheStart == true)
        {

            if (avalancheStart == false)
            {

                avalancheStart = true;
                double clipDuration = (double)avalancheStartAudio.clip.samples / avalancheStartAudio.clip.frequency;
                avalancheStartAudio.PlayScheduled(AudioSettings.dspTime + 0.1);
                avalancheMiddleAudio.PlayScheduled(AudioSettings.dspTime + 0.1 + clipDuration);

            }

        }


        speed = avalancheRigidBody.GetComponent<Rigidbody>().velocity.magnitude;

        // Check to see if the avalanche has dropped below the avalancheStopSpeed variable

        if (speed > avalancheStopSpeed)
        { stoppedCheck = true;  }

        if (stoppedCheck == true)
        {

            if (speed < avalancheStopSpeed)
            { 

                if (avalancheStopped == false)
                {
                    
                        StartCoroutine("StopAvalanche");

                }

            }

        }


    }

    IEnumerator StartAvalanche()
    {

        avalancheRigidBody.SetActive(true);

        yield return new WaitForSeconds(2.0f);

  
    }

    IEnumerator StopAvalanche()
    {

        avalancheStopped = true;

        yield return new WaitForSeconds(2.0f);

        avalancheRigidBody.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        avalancheMiddleAudio.Stop();
        avalancheEndAudio.Play();

    }




}