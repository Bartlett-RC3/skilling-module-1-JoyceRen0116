using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roationtoface : MonoBehaviour
{


    public Transform objecttarget;
    public float strength;

    // Use this for initialization
    void Start () {
       transform.rotation = Quaternion.Euler(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {

	    
        // dirctionTOface = destion - source
        Vector3 dirction = transform.position - objecttarget.position; 
	    
        Quaternion rotation = Quaternion.LookRotation(dirction);
        transform.rotation = Quaternion.Slerp(transform.rotation,rotation, strength * Time.deltaTime);

    }
}
