using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Panda;

public class turnBased : MonoBehaviour
{
 
    // deal cards
    // draw a card
    // put the obj on the card to a grid
    // the bird acts

    //public int amountsCards; // how many cards would be gened this turn. depends on which month

    public int turn;

    outerAI _outerAI;

   // bool ibisCanMove;

    Vector3 cardPos1;
    Vector3 cardPos2;
    Vector3 cardPos3;

    GameObject _ibisA;

    // listObjOnLand _listObjOnLand;

   

    public static GameObject MouseUp_currentLand;

    public static GameObject MouseDrag_currentLand; //???

    public static GameObject MouseOver_currentLand;




    public delegate void MethodOneDelegate();

   public  void executeMethod(MethodOneDelegate function)
    {
        function();
    }


    void Start()
    {
        //first Start() -> first turn starts -> x turn ends -> new turn starts
        MouseUp_currentLand = null;

        turn = 0;
        // ibisCanMove = false;

        _outerAI = GameObject.Find("Values").GetComponent<outerAI>();

        _ibisA = GameObject.Find("ibisA");

        newTurnStart();

        //gameObject.GetComponent<Panda.Ibis.MyTurn>().enabled =false;

    }

    void Update()
    {
        /*        if (ibisCanMove)
                {
                    //main Ai logic here
                }*/

            //print("current land: " + MouseUp_currentLand.name);

    }

    public  void newTurnStart()
    {
        /////check all the noamal properties and make changes
        //Check:
        checkIbis();

        turn = turn + 1;
        /// //execute diff season 's methods
        checkSeasons(turn);

        GameObject _thisTurn = Instantiate(Resources.Load("goj/thisTurn")) as GameObject;
        _thisTurn.transform.SetParent(gameObject.transform);

        transform.GetChild(0).gameObject.GetComponent<PandaBehaviour>().Reset();


        print("turnBased: new turn start." );
    }

  void checkIbis()
    {
        if (Panda.Ibis.MyIbis.full <= 0)
        {
            //ibisA die,Game Over.

        }
        if (Panda.Ibis.MyIbis.energy <= 0)
        { 
            //? next turn's action point would be reduced.
        }
    }

    void checkSeasons(int currentTurn ) // turn => Seasons(); 
    {
        if (currentTurn == 1) { _outerAI.Jul1(); _outerAI.month = 7; } // need to check the turn?
        if (currentTurn == 2) { _outerAI.Jul2(); _outerAI.month = 7; }
        if (currentTurn == 3) { _outerAI.Aug1(); _outerAI.month = 8; }
        if (currentTurn == 4) { _outerAI.Aug2(); _outerAI.month = 8; }
        if (currentTurn == 5) { _outerAI.Sept1(); _outerAI.month = 9; }
        if (currentTurn == 6) { _outerAI.Sept2(); _outerAI.month = 9; }
        if (currentTurn == 7) { _outerAI.Oct1(); _outerAI.month = 10; }
        if (currentTurn == 8) { _outerAI.Oct2(); _outerAI.month = 10; }
        if (currentTurn == 9) { _outerAI.Nov1(); _outerAI.month = 11; }
        if (currentTurn == 10) { _outerAI.Nov2(); _outerAI.month = 11; }
        if (currentTurn == 11) { _outerAI.Dec1(); _outerAI.month = 12; }
        if (currentTurn == 12) { _outerAI.Dec2(); _outerAI.month = 12; }
        if (currentTurn == 13) { _outerAI.Jan1(); _outerAI.month = 1; }
        if (currentTurn == 14) {_outerAI.Jan2(); _outerAI.month = 1; }
        if (currentTurn == 15) { _outerAI.Feb1(); _outerAI.month = 2; }
        if (currentTurn == 16) { _outerAI.Feb2(); _outerAI.month = 2; }
        if (currentTurn == 17) { _outerAI.Mar1(); _outerAI.month = 3; }
        if (currentTurn == 18) { _outerAI.Mar2(); _outerAI.month = 3; }
        if (currentTurn == 19) { _outerAI.Apr1(); _outerAI.month = 4; }
        if (currentTurn == 20) { _outerAI.Apr2(); _outerAI.month = 4; }
        if (currentTurn == 21) { _outerAI.May1(); _outerAI.month = 5; }
        if (currentTurn == 22) { _outerAI.May2(); _outerAI.month = 5; }
        if (currentTurn == 23) { _outerAI.Jun1(); _outerAI.month = 6; }
        if (currentTurn == 17) { _outerAI.Jun2(); _outerAI.month = 6; }

    }


}
