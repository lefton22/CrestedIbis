using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Panda;

namespace Panda.Ibis
{
    public class MyNPC : MonoBehaviour
    {

        void Start()
        {

        }


        void Update()
        {

        }


        [Task]
        void snake_seekNestWithEgg()
        {
            Debug.Log("snake seek Nest With Egg.");
        }

        [Task]
        void snake_eatEgg()
        {
            Debug.Log("snake eat one egg.");
        }
    }
}



