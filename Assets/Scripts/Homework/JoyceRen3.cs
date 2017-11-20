using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyceRen3 : MonoBehaviour {



    //variables
    int counter = 0;
    public GameObject Joycecube;
    public GameObject SoundEffect;
   
    public Material JoyceMat;
    bool moveleft = true;
    bool moveright = false;
   




	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {


        if (moveleft == true )
        {

            JoyceMat.color = Color.black;

            if (counter <= 30)
            {
                Joycecube.transform.Translate(Vector3.left);
                counter++;
            }
            else if (counter > 30 && counter<=60)
            {
                
                Joycecube.transform.Translate(Vector3.right);
                counter++;

            }else if(counter >60){
                moveright = true;
                moveleft = false;
                counter = 0;
            }

          

        }


        if (moveright == true)
        {

            JoyceMat.color = Color.white;

            if (counter <= 30)
            {
                gameObject.transform.Translate(Vector3.right);
                counter++;
               
            }

            else if (counter >30 && counter<=60)
            {
                Joycecube.transform.Translate(Vector3.left);
                counter++;
            }else if (counter>60)
            {
                moveleft = true;
                moveright = false;
                counter = 0;
            }
        }

 

       

        if (Input.GetMouseButton(0))
        {
            JoyceMat.color = Color.red;
        }

        if (Input.GetMouseButton(1))
        {
            JoyceMat.color = Color.blue;
            SoundEffect.GetComponent<AudioSource>().Play();
        }




        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.Rotate(new Vector3(0, 5, 0));
            SoundEffect.GetComponent<AudioSource>().Play();
        }




        }






        //this.transform.position =
        //new Vector3(transform.position.x+ (3 * Time.deltaTime), transform.position.y + (3*Time.deltaTime), transform.position.z);

        //along the world z axisin wirld space (self :move in local space along the forward z axis)
        //float speed = 2;
        //this.transform.Translate(0f,speed * (Time.deltaTime) ,0f,Space.World);

        ////Rotation(rotate the object using Euler angles)
        //float speed = 90;
        //this.transform.Rotate(0f, (speed * Time.deltaTime), 0f, Space.Self); 

        ////Rotate the object using a vector
        //float speed = 90;
        //this.transform.Rotate(new Vector3(1f, 1f, 1f), speed * Time.deltaTime, Space.Self);

        ////rotate the object using a vector, with debug info showing us where the vector is
        //float x = 0.45f, y =1f,z =1f;
        //float rotationSpeed = 90;
        //this.transform.Rotate(new Vector3(x,y,z),rotationSpeed *Time.deltaTime,Space.Self);

        //Vector3 topPoint = new Vector3(this.transform.position.x + x,
        //                               this.transform.position.y + y,
        //                               this.transform.position.z + z);
        //Vector3 bottomPoint = new Vector3(this.transform.position.x - x,
        //                                  this.transform.position.y - y,
        //                                  this.transform.position.z - z);

        //Debug.DrawLine(topPoint,bottomPoint);


        ////scale the object to 5 times its size
        //float scale = 5;
        //transform.localScale = new Vector3(scale, scale, scale);


 //       MoveTowardsTarget(Vector3.zero);
 //       RotateTowardsTarget(Vector3.zero);
 //       PulseObeject();
	}

    





//private void MoveTowardsTarget(Vector3 targetPosition){
    //    // the speed, in units per second, we want to move towards the target
    //    float speed = 1;

    //    Vector3 currentPosition = this.transform.position;
    //    // first, check to see if we are close enough to target
    //    //this check prevents us from oscillating back and forth over the target
    //    //if we are father than 1 unit away, do the movement, otherwise do nothing
    //    if(Vector3.Distance(currentPosition,targetPosition)>1){

    //        //get the directiono we need to go to by subtracting the current position from the target position
    //        Vector3 directionOfTravel = targetPosition - currentPosition;

    //        directionOfTravel.Normalize();

    //        this.transform.Translate(
    //            (directionOfTravel.x*speed*Time.deltaTime),
    //            (directionOfTravel.y*speed*Time.deltaTime),
    //            (directionOfTravel.z*speed*Time.deltaTime),
    //             Space.World);
    //    }

    //}


    //private void RotateTowardsTarget(Vector3 targetPosition){
    //    float speed = 45;
    //    Vector3 currentPosition = this.transform.position;

    //    Quaternion currentRotation = this.transform.rotation;

    //    Vector3 directionOfLook = targetPosition - currentPosition;

    //    Quaternion targetRotation = Quaternion.LookRotation(directionOfLook);

    //    transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, Time.deltaTime * speed);

    //}

    //private void PulseObeject(){
    //    float rate = .5f;
    //    float maxScale = 1.2f;
    //    float minScale = .8f;

    //    float scale = (Mathf.Sin(Time.time * (rate * 2 * Mathf.PI)) + 1f) / 2f;

    //    scale = Mathf.Lerp(minScale, maxScale, scale);

    //    transform.localScale = new Vector3(scale, scale, scale);

    //}


























