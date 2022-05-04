using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Panda;

//enable this script once new turn start

// deal cards
// draw a card
// put the obj on the card to a grid
// the bird acts

namespace Panda.Ibis
{
    public class MyTurn : MonoBehaviour
    {

        List<GameObject> cards;

        List<GameObject> cardSlots;

        //int turn;// abandoned int turn in turnBased 

        public bool hasIbisEnded;

        GameObject _ibisA;

        GameObject _turnBased;

        GameObject _targetPos; 
        Vector3  v3_targetPos;

        public  List<GameObject> cardPoses;

        outerAI _outerAI;

        public int s1Card;
        public int s2Card;
        public int s3Card;
        public int s4Card;

        GameObject _Cards;

        GameObject _cardPos3;

        int cardSlotsAmounts;

        listObjOnLand _listObjOnLand;

        bool isGencards;

        int thisAmount;

        int amount_ObjOnLand;

        MyIbis _myIbis;

        public bool hasSetPandaActive;

        public bool hasSetNPCTreeActive;
        void Start()
        {
            cards = new List<GameObject>();
            cardSlots = new List<GameObject>();

            hasIbisEnded = false;

            _ibisA = GameObject.Find("ibisA");
            _turnBased = GameObject.Find("TurnBased");

            _targetPos = GameObject.Find("Target2");
            v3_targetPos = _targetPos.transform.position;

            _outerAI = GameObject.Find("Values").GetComponent<outerAI>();

            _Cards = GameObject.Find("Cards");
            _cardPos3 = GameObject.Find("cardPos3");

            cardSlotsAmounts = 0;

            _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();

            isGencards = false;

            thisAmount = -1;

            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {
                if (child.transform.gameObject.tag == "food" || child.transform.gameObject.tag == "egg" ||
                    child.transform.gameObject.tag == "nest" || child.transform.gameObject.tag == "ibis" ||
                    child.transform.gameObject.tag == "npc" || child.transform.gameObject.tag == "humanStaff" ||
                    child.transform.gameObject.tag == "material")
                {
                    //ifHasCrad = 1;
                    amount_ObjOnLand = amount_ObjOnLand + 1;
                    // print("cardsDrew : " + cardsDrew);
                }
               
            }
           // print("amount_ObjOnLand: " + amount_ObjOnLand);

            _myIbis = GameObject.Find("ibisA").GetComponent<Panda.Ibis.MyIbis>();

            hasSetPandaActive = false;

            hasSetNPCTreeActive = false;


        }


        [Task]
        void NPCAct()
        {

            if (!hasSetNPCTreeActive)
            {
                //gen a npc behavior tree
                GameObject npcOrder_snake = Instantiate(Resources.Load("goj/NpcOrder_snake")) as GameObject;
                npcOrder_snake.transform.SetParent(_turnBased.transform);
                npcOrder_snake.GetComponent<PandaBehaviour>().Reset();

                //NpcOrder_egret
                GameObject npcOrder_egret = Instantiate(Resources.Load("goj/NpcOrder_egret")) as GameObject;
                npcOrder_egret.transform.SetParent(_turnBased.transform);
                npcOrder_egret.GetComponent<PandaBehaviour>().Reset();

                hasSetNPCTreeActive = true;
            }
            /*            if (hasSetNPCTreeActive)
                        {
                            Destroy(_npcOrder);
                            ThisTask.Succeed();
                        }*/

            if (Panda.Ibis.MyNPC.end)
            {
                GameObject[] npcOrders;
                npcOrders = GameObject.FindGameObjectsWithTag("npcOrder");
                foreach (GameObject npcO in npcOrders)
                { Destroy(npcO); }

                ThisTask.Succeed();
            }
        }

        [Task]
        void checkAllObjNPC()
        {

            /*            //only for test
                        GameObject[] eggs1;
                        eggs1 = GameObject.FindGameObjectsWithTag("egg");
                        foreach (GameObject goj in eggs1)
                        {
                            if (!Panda.Ibis.MyIbis.eggs.Contains(goj))
                            { Panda.Ibis.MyIbis.eggs.Add(goj); }
                        }

                        //only for test*/

            print("turnBased: new turn start.");

            if (Panda.Ibis.MyIbis.eggs.Count > 0)  // if the egg can hatch, hatch them into baby ibis
            {
                foreach (GameObject egg in Panda.Ibis.MyIbis.eggs)
                {
                    egg.GetComponent<objEgg>().checkHatch();
                }
                //Panda.Ibis.MyIbis.eggs.Clear();
            }

            ThisTask.Succeed();
        }

        [Task]
        void dealCards()
        {
            _myIbis.setIsObjOnLand();

            Panda.Ibis.MyIbis.actionPoint = 0;

            _targetPos.transform.position = new Vector3(_targetPos.transform.position.x, 6f, 1f);

            if (!isGencards)
            { genCards();
                isGencards = true;
            }

            if (cards.Count == thisAmount)
            {
               // print("card 3?");
                ThisTask.Succeed(); }

        }

        [Task]
        void drawCards()
        {
            cardSlotsAmounts = 0;
            cardSlots.Clear();
            cards.Clear();

            int cardsCanDraw;
            cardsCanDraw = -1;
            if (amountsCards(_outerAI.month) >= 4)
            { cardsCanDraw = amountsCards(_outerAI.month) - 2; }
            if (amountsCards(_outerAI.month) < 4 && amountsCards(_outerAI.month) > 0)
            { cardsCanDraw = amountsCards(_outerAI.month) - 1; } //暂时的


            int cardsDrew;
            cardsDrew = 0;
            //cardsDrew = amountsCards(_outerAI.month);
           // print("cardsDrew0: " + cardsDrew + " , " + "cardsCanDraw0: " + cardsCanDraw);

            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
                {
 
                    if (child.transform.gameObject.tag == "food" || child.transform.gameObject.tag == "egg" ||
                    child.transform.gameObject.tag == "nest" || child.transform.gameObject.tag == "ibis" ||
                    child.transform.gameObject.tag == "npc" || child.transform.gameObject.tag == "humanStaff" ||
                        child.transform.gameObject.tag == "material")
                    {
                        //ifHasCrad = 1;
                        cardsDrew = cardsDrew + 1;
                       // print("cardsDrew : " + cardsDrew);
                    }


                }
            /*            if (ifHasCrad == 2)
                        {
                            ThisTask.Succeed();
                        }*/

            if (cardsDrew >= cardsCanDraw + amount_ObjOnLand)
            {
               // print("cardsDrew: " + cardsDrew + " , " + "cardsCanDraw: " + cardsCanDraw);
                //Destory all cards stuff belongs to this turn
                foreach (Transform child in _Cards.transform)
                {
                    Destroy(child.gameObject);
                }
/*                foreach (Transform child in GameObject.Find("ObjOnLand").transform)
                {
                    if (child.transform.gameObject.tag == "food" || child.transform.gameObject.tag == "egg" ||
                        child.transform.gameObject.tag == "nest" || child.transform.gameObject.tag == "ibis" ||
                        child.transform.gameObject.tag == "npc" || child.transform.gameObject.tag == "humanStaff" ||
                        child.transform.gameObject.tag == "material")
                    {
                        //Destroy(child.gameObject);
                    }
                }*/

                    ThisTask.Succeed();
            }
        }

        [Task]
        void ibisAct()
        {


            if (!hasSetPandaActive)
            {
                foreach (Transform child in _ibisA.transform)
                {
                    child.gameObject.SetActive(true);

                    child.gameObject.GetComponent<PandaBehaviour>().Reset();

                }

                _ibisA.transform.GetChild(0).gameObject.GetComponent<PandaBehaviour>().enabled = true;
                hasSetPandaActive = true;
            }
            if (hasIbisEnded)
            {
              //  _ibisA.transform.GetChild(0).gameObject.GetComponent<PandaBehaviour>().enabled = false;
                ThisTask.Succeed(); 
            }
        }

        [Task]
        void endThisTurn() // copy this to attached MaxAP
        {
            _ibisA.GetComponent<Panda.Ibis.MyIbis>().landsPassThrough.Clear();
            // _ibisA.GetComponent<PandaBehaviour>().enabled = false;
            foreach (Transform child in _ibisA.transform)
            {
                child.gameObject.GetComponent<PandaBehaviour>().Reset();
                child.gameObject.GetComponent<PandaBehaviour>().enabled = false;
            }

            _turnBased.GetComponent<turnBased>().newTurnStart();

            // gameObject.GetComponent<PandaBehaviour>().enabled = false;

            gameObject.GetComponent<PandaBehaviour>().Reset();

            
           
            //?
            ThisTask.Succeed();

            Destroy(gameObject);
            
        }

        //////////////////////////
        /////////////////////////
        ////////////////////////

        void genCards()
        {
            //int x = Screen.width / 2;

            Vector3 v3_middleCard;
            v3_middleCard = _cardPos3.transform.position; ;



          
            thisAmount = amountsCards(_outerAI.month);

            if (cardSlotsAmounts <= thisAmount)
            {

                for (int i = 0; i < thisAmount; i++)
                {

                    GameObject cardSlot = Instantiate(Resources.Load("goj/cardPos")) as GameObject;
                    cardSlot.transform.position =
                         new Vector3(v3_middleCard.x - (thisAmount - 1) + i * 2f, v3_middleCard.y, v3_middleCard.z);

                    cardSlot.transform.SetParent(_Cards.transform);
                    cardSlot.name = "cardSlot" + i.ToString();

                    cardSlotsAmounts = cardSlotsAmounts + 1;


                    if (!cardSlots.Contains(cardSlot))
                    { cardSlots.Add(cardSlot); }

                  

                }
              //  print("cardSlots count: " + cardSlots.Count +" this turn: " +GameObject.Find("TurnBased").GetComponent<turnBased>().turn);
            } 

            if (cards.Count <= cardSlots.Count)
            {

                for (int k = 0; k < cardSlots.Count; k++)
                {
                  
                    GameObject card = Instantiate(Resources.Load("card0")) as GameObject;
                    card.transform.SetParent(_Cards.transform);
                    card.transform.position = cardSlots[k].transform.position;

                    card.name = "card" + k.ToString();


                    //card.GetComponent<SpriteRenderer>().sprite = Resources.Load()

                    if (!cards.Contains(card))
                    { cards.Add(card); }

                    GameObject obj = Instantiate(Resources.Load("obj/obj")) as GameObject;
                    obj.transform.SetParent(card.transform);
                    obj.GetComponent<SnapToNode>().enabled = false;
                    obj.transform.position = new Vector3(999f, 999f, 999f);
                    obj.transform.localScale = new Vector3(1f,1f,1f);

                    //decide what this card is
/*                    int random_index;
                    random_index = Random.Range(0, _listObjOnLand.objOnLand.Count);
                    obj.name = _listObjOnLand.objOnLand[random_index];*/

                    // 上面是暂时的，下面是真的
                    int rough_ran_index;

                    rough_ran_index = Random.Range(0, _outerAI.cardsWeight.Count); //_outerAI.cardsWeight is set in seasons
                                                                                   //1=rich food , 2= ave food ,3= poor food,,,,
                                                                                   // 6= neutral NPC, 7 = mal NPC, 8 = good NPC
                                                                                   //11 = nest
                                                                                   //16 = human-made building
                                                                                   //21 = building material

/*                    _outerAI.Jul1();
                    _outerAI.checkCardsWeight();
                    print("3 " + _outerAI.cardsWeight.Count);*/
                   
                    if (_outerAI.cardsWeight[rough_ran_index] == 1)
                    {
                        //0,1,nbvzas2,3,4,5,6,7,8, of ListObjOnLand.ObjOnLand=rich
                        // var _whichObj =  obj.GetComponent("whichObj") as MonoBehaviour;
                        //_whichObj.

                        range_e_index(0, 8, 1, obj, card);
                      
                        obj.GetComponent<whichObj>().richFood();

                    }
                    if (_outerAI.cardsWeight[rough_ran_index] == 2)
                    {
                        //9,10,11 = ave
                        range_e_index(9, 11, 1, obj, card);

                       obj.GetComponent<whichObj>().aveFood();

                    }
                    if (_outerAI.cardsWeight[rough_ran_index] == 3)
                    {
                        //12 = poor
                        range_e_index(12, 12, 1, obj, card);

                       obj.GetComponent<whichObj>().poorFood();

                        
                    }
                    if (_outerAI.cardsWeight[rough_ran_index] == 6) //6 = neutral NPC
                    {
                        range_e_index(16, 18, 2, obj, card);

                       // obj.GetComponent<whichObj>().neutralNPC();
                    }
                    if (_outerAI.cardsWeight[rough_ran_index] == 7) //7 = mal NPC
                    {
                        range_e_index(19, 20, 2, obj, card);

                        //obj.GetComponent<whichObj>().malNPC();
                    }
                    if (_outerAI.cardsWeight[rough_ran_index] == 8) //8 = good NPC
                    {
                             //?...good npc?
                    }
                    if (_outerAI.cardsWeight[rough_ran_index] == 11) //11 = nest
                    {
                        range_e_index(21, 21, 3, obj, card);
   
                       // obj.GetComponent<whichObj>().nest();
                    }
                    if (_outerAI.cardsWeight[rough_ran_index] == 16) //16 = human-made building
                    {
                        range_e_index(22, 22, 4, obj, card);

                       // obj.GetComponent<whichObj>().building();
                    }
                    if (_outerAI.cardsWeight[rough_ran_index] == 21) //21 =  building material
                    {
                        range_e_index(14, 15, 5, obj, card);

                      //  obj.GetComponent<whichObj>().material();
                    }

                }
            }
        }

        public int amountsCards(int Month)
        {
            int amounts;
            amounts = 0;
            if (_outerAI.month == 1 || _outerAI.month == 2 || _outerAI.month == 3)
            { amounts = s1Card; }
            if (_outerAI.month == 4 || _outerAI.month == 5 || _outerAI.month == 6)
            { amounts = s2Card; }
            if (_outerAI.month == 7 || _outerAI.month == 8 || _outerAI.month == 9)
            { amounts = s3Card; }
            if (_outerAI.month == 10 || _outerAI.month == 11 || _outerAI.month == 12)
            { amounts = s4Card; }

            return amounts;
        }

        void range_e_index(int a, int b, int _which, GameObject _obj, GameObject _card)
        {
            int random_index;
            random_index = Random.Range(a, b);
           // print(" _listObjOnLand: " + _listObjOnLand.objOnLand);

         //   print("name: " + _listObjOnLand.objOnLand[random_index]);
            _obj.name = _listObjOnLand.objOnLand[random_index];

           _obj.GetComponent<whichObj>(). which = _which;

            Sprite sp_card;
            sp_card = Resources.Load<Sprite>("cards/card_" + _obj.name.ToString());
            _card.GetComponent<SpriteRenderer>().sprite = sp_card;
            _card.GetComponent<SpriteRenderer>().sortingOrder = 100;

            Sprite sp_obj;
            sp_obj = Resources.Load<Sprite>("obj/" + _obj.name.ToString());
            _obj.GetComponent<SpriteRenderer>().sprite = sp_obj;
        }
    }
}
