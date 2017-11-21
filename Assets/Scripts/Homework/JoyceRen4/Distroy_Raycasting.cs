using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distroy_Raycasting : MonoBehaviour
{
    public GameObject Drink;
    public GameObject Eaten;
    public Material JoyMat;



    // Use this for initialization
    void Start()
    {
      
    }

    //Update is called once per frame

        void Update()
    {


     
        Vector3 Left = transform.TransformDirection(Vector3.left);
        Vector3 Right = transform.TransformDirection(Vector3.right);
        Vector3 Forward = transform.TransformDirection(Vector3.forward);
        Vector3 Back = transform.TransformDirection(Vector3.forward);


        RaycastHit Mushroom;

       



        if (Physics.Raycast(transform.position, Left, out Mushroom,2))

        {
            Destroy(Mushroom.transform.gameObject);

            Drink.GetComponent<AudioSource>().Play();

            Debug.Log(Mushroom.transform.gameObject.name+ " be eaten! " + "Energy + 1 ");

        }
           


        if (Physics.Raycast(transform.position, Forward, out Mushroom, 2))

        {
            Destroy(Mushroom.transform.gameObject);

            Drink.GetComponent<AudioSource>().Play();

            Debug.Log(Mushroom.transform.gameObject.name + " be eaten! " + "Energy + 1 ");


        }
     



         
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 0.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.1f);
        }


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 0.1f);
        }


    }
   

}