using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits1 : MonoBehaviour {

    string[] fruits = { "banana", "apple", "mango", "blueberry" };

	// Use this for initialization
	void Start () {
        for (int i = 0; i < fruits.Length; i = i + 1)
        {
            Debug.Log("Fruit at position " + i + "is " + fruits[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
