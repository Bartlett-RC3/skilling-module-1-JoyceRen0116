using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyceRen1 : MonoBehaviour
{
    
    //1.Declare a int variable and set a value
    //2.Declare a float variable and set a value
    //3.Declare a string variable and set a value

    //variables (Scope -- Type -- Name -- Value)
    public int Floor = 2;
    public float PosX = 2.14f;
    public string text = "Hello RC3";
    public bool CoolGuys = true;


    //5.Declare and initialize an array
    string[] WRCHGroup = new string []{" Joyce"," Zim"," Caelyn"," Ning"};


    //6.Declare and initialize a list
    List<string> RC3 = new List<string>() { "Joyce","Caelyn","Ning","Zim" };

    //7.Create and initialize a Dictionary    Keypoint!!!<key,value>
    public Dictionary<string, string> COOLRC3Tutors = new Dictionary<string, string>();



    //4.Create a function that prints the declared variables
    // Use this for initialization
    void Start()
    {
        RC3.Add("Jelena");
        RC3.Add("Jialin");
        RC3.Add("James");
        RC3.Add("Hongyou");
        RC3.Add("Wu");
        RC3.Add("Shahrzard");
        RC3.Add("Mo");
        RC3.Add("Alkhaja");
        RC3.Add("Yekta");
        RC3.Add("Skyler");
        //RC3.Remove("Jialin"); 


        Debug.Log("Hello RC3 " + PosX);
        Debug.Log("All members" +RC3.Count);
        Debug.Log("RC3 Member 1 " + RC3[0]);
        Debug.Log("RC3 Last Member " + RC3[RC3.Count-1]);
        Debug.Log("List to Array length " + RC3.ToArray().Length);


        COOLRC3Tutors.Add("Member 1", "Octavian");
        COOLRC3Tutors.Add("Member 2", "Tyson");
        COOLRC3Tutors.Add("Member 3", "Dave");
        Debug.Log("TutorMember 1 " + COOLRC3Tutors["Member 1"]);
        Debug.Log("TutorMember 2 " + COOLRC3Tutors["Member 2"]);


        //My for loop first try
        WRCHGroup[0] = " Joyce";
        Debug.Log(" WRCH "+ ":" + WRCHGroup[0] + WRCHGroup[1] + WRCHGroup[2] + WRCHGroup[3]);
        for (int i = 0; i < 4; i=i+1)
        {
            Debug.Log("Member" +(i+1)+ "is" + WRCHGroup[i]); 
        }


        text = TEST("VedioGame");
       
    }



    //MyFunctions(Methods)
   
 
    string TEST(string value)
    {
        return value + " ：Life Game!";
    }





    // Update is called once per frame
    void Update()
    {

    }


   



}
