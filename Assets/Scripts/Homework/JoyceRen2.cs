using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JoyceGame;

public class JoyceRen2 : MonoBehaviour
{

//homework2



    //Variables
    public string Name = "Joyce";
    public int Wealth = 100;
    bool Cool = true;
    string[] Apps = new string[] { "Unity", "Rhino","GH", "PS" };
    string[] WRCHGroup = new string[] { " Joyce", " Zim", " Caelyn", " Ning" };
    public Dictionary<string, string> COOLRC3Tutors = new Dictionary<string, string>();


    List<Dog> Dogfamily = new List<Dog>();


    // Use this for initialization
    void Start()
    {
        //Dog cc = new Dog();
        //Debug.Log(cc.health +" / "+cc.maxHealth);
        //Debug.Log("Heath " + cc.CorrentHealthPercent()+"%");


        COOLRC3Tutors.Add("Member 1", "Octavian");
        COOLRC3Tutors.Add("Member 2", "Tyson");
        COOLRC3Tutors.Add("Member 3", "Dave");

        ConditionTest();
        JoyceLoop();


   //3.DogClass

        Dog Max = new Dog("Max", "white", true, true, 2);
        Dog Maya = new Dog("Maya", "brown", false, true, 1);
        Dog Rhino = new Dog("Rhino", "black", true, true, 3);

        Dogfamily.Add(Max);
        Dogfamily.Add(Maya);
        Dogfamily.Add(Rhino);

   
        for (int i = 0; i < Dogfamily.Count;i++)
        {
            Debug.Log(Dogfamily[i].Getname() +" is " + Dogfamily[i].GetAge()+" years old! "); 
            Debug.Log(Dogfamily[i].Getname() + " is " + Dogfamily[i].GetColor());

        }
       

    
    }



//1.Write a function that uses a condition   (&&:And ; ||:Or)
  
    void ConditionTest()
    {
        if (Name == "Joyce" && Cool == true)
        {
            Debug.Log("Joyce is Cool!");
        }
        else{
            Debug.Log("Joyce is not happy!");
        }
       

        if (Name == "Zim" && Cool == true)
        {
            Debug.Log("Zim is Cool!");
        }
        else {
            Debug.Log("Zim is not happy!");
        }
    


        //Shorthand conditions
        bool Happy = Wealth >= 100;
        Debug.Log("Happy " + Happy);

        if (Happy)
            Debug.Log("Player is wealthy!");

        string Mode = Happy == true ? "wealthy" : "Poor";
        Debug.Log("Player is very " + Mode+ " !");


    }


//2.Write a for loop
    void JoyceLoop()
    {
        for (int i = 0; i < WRCHGroup.Length; i++)
        {
            Debug.Log(WRCHGroup[i] + " is in Joyceloop!!! ");
        }

        for (int i = 3; i >-1; i--)
        {
            Debug.Log(WRCHGroup[i] + " is Really Happy!!! ");
        }

        foreach (string Software in Apps)
        {
            print(Software); 
        }

        foreach(var item in COOLRC3Tutors ){
            print("CoolTutor " + item.Key  + " is " +item.Value ); 
        }
    }




    // Update is called once per frame
    void Update()
    {
      
    }
}