using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColor : MonoBehaviour {

    public GameObject Cute;
    public Material JoyceMaterial;


    private Color[] cubeColors = new Color[]{Color.red,Color.yellow,Color.white,Color.gray,Color.yellow,Color.green,Color.black,Color.red};



	// Use this for initialization
	void Start () {
   
        StartCoroutine(Changing());
	}


    IEnumerator Changing()
    {
        while (true)
        {
            for (int i = 0; i < cubeColors.Length; i++)
            {
                yield return new WaitForSeconds(0.2f);

                JoyceMaterial.color = cubeColors[i];


                Debug.Log(Time.time + " is " + cubeColors[i]);
            }
        }
    }




	// Update is called once per frame
	void Update () {
		
	}
}
