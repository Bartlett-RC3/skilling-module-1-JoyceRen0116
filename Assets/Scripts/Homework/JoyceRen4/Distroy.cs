using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distroy : MonoBehaviour
{

    // variables


    void OnTriggerExit(Collider other)
    {
        // Destroy everything that leaves the trigger
        Destroy(other.gameObject);

        if (other.gameObject.tag == "AddLife")
            //物件。取得属性《渲染器》（）。材质。颜色。黄
            gameObject.GetComponent<Renderer>().material.color = Color.red;
    }



    // Use this for initialization
    void Start()
    {
       
    }




    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
            this.transform.Translate(0, 0, -1 * 8 * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            this.transform.Translate(0, 0, 1 * 8 * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            this.transform.Translate(-1 * 8 * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.D))
            this.transform.Translate(1 * 8 * Time.deltaTime, 0, 0);



    }
}
