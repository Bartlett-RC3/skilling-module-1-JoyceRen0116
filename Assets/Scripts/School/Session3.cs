using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3 : MonoBehaviour {

    //variables
    int counter = 0;
    public GameObject cubeReference;
    bool moveleft = true;
    bool moveright = false;


	// Use this for initialization
	void Start () {
      // for (int i = 0; i < 10000; i++)
        {
           /*
            Vector3 cubePosition = new Vector3(i + 0.5f,0,0);
            Quaternion cubeRotation = Quaternion.identity;
            GameObject newCube = Instantiate(cubeReference, cubePosition, cubeRotation);
            */

        }
		
	}
	
	// Update is called once per frame
	void Update () {
        //Time in frams , not very useful because of variiation
        if (moveleft == true)
        {
            if(counter <=15)
            {
                //this.gameObject.GetComponent<Transform>().position = new Vector3(counter*(-1), 0, 0);
                gameObject.transform.Translate(Vector3.left);
                counter++;
            }
            else 
            {
               moveleft = false;
               moveright = true;
                counter = 0;
            }
        }


        if (moveright == true)
        {
            if (counter <=15)
            {
                gameObject.transform.Translate(Vector3.right);
                counter++;
            }
            else
            {
                moveleft = true;
                moveright = false;
                counter = 0;
            }
        }



        //keyboad input

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.Rotate(new Vector3(0,5,0) ); 
        }

        if(Input.GetMouseButton(0) )
        {
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        if (Input.GetMouseButton(1))
        {
            gameObject.transform.localScale = new Vector3(1,1,1);
        }


	}
}
