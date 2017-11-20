using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour {

    int counter = 0;
    public GameObject Joycecube;
    public GameObject SoundEffect;

    public Material JhonMat;
    bool moveup = true;
    bool movedown = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (moveup == true)
        {

            JhonMat.color = Color.white;

            if (counter <= 30)
            {
                Joycecube.transform.Translate(Vector3.up);
                counter++;
            }
            else if (counter > 30 && counter <= 60)
            {

                Joycecube.transform.Translate(Vector3.down);
                counter++;

            }
            else if (counter > 60)
            {
                movedown = true;
                moveup = false;
                counter = 0;
            }



        }


        if (movedown == true)
        {

            JhonMat.color = Color.red;

            if (counter <= 30)
            {
                gameObject.transform.Translate(Vector3.down);
                counter++;

            }

            else if (counter > 30 && counter <= 60)
            {
                Joycecube.transform.Translate(Vector3.up);
                counter++;
            }
            else if (counter > 60)
            {
                moveup = true;
                movedown= false;
                counter = 0;
            }
        }





        if (Input.GetMouseButton(0))
        {
            JhonMat.color = Color.yellow;
        }

        if (Input.GetMouseButton(1))
        {
            JhonMat.color = Color.green;
            SoundEffect.GetComponent<AudioSource>().Play();
        }




        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.Rotate(new Vector3(0, 5, 0));
            SoundEffect.GetComponent<AudioSource>().Play();
        }



	}
}
