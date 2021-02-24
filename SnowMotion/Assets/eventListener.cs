using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class eventListener : MonoBehaviour
{
    public EventTrigger trigger;

    // Start is called before the first frame update
    void Start()
    {
        trigger = GetComponent<EventTrigger>( );
        EventTrigger.Entry entry = new EventTrigger.Entry( );
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener( ( data ) => { OnPointerDownDelegate( ( PointerEventData ) data ); } );
        trigger.triggers.Add( entry );  
    }

    public void OnPointerDownDelegate( PointerEventData data )
    {
             foo( 100,"Hello World" );
    }

    void foo (int a, string b) {
             Debug.Log( a + " " + b );
    }
}