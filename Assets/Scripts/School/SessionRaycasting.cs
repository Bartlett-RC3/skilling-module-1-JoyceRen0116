using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionRaycasting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       

        //Raydirection
        Vector3 CastedRayDirection = transform.TransformDirection(Vector3.forward);

        //RaycastHit
        RaycastHit objectInFront;

        //Raycasting
        if (Physics.Raycast(transform.position, CastedRayDirection,out objectInFront))
        {
            string objectInFrontName = objectInFront.transform.name;
            Debug.Log("There is an object in front of me! It's name is"+ objectInFrontName ); 
        }



        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 0.01f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 0.01f);
        }




    }
}
