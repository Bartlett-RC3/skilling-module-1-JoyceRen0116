using System;
using UnityEngine;
namespace JoyceGame
{
    public class Player : Dog
    {
        public Player()
        {
            RestoreHealth();
        }

        override public void RestoreHealth(){
            for (int i = health; i <= maxHealth;i++){
                health = i;
                Debug.Log("Health" + health);
            }
        }

    }
}
