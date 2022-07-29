using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Panda;

using Pathfinding;

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

       // LandGen2 _LandGen2;

        LandGen3 _LandGen3;

        allCheck _allCheck;

        public bool drawCardShouldEnd;

       int pollutionTimesEachTurn;
        int TimesHasPolluttedEachTurn;
        bool hasCalculateAP;

        void Start()
        {
            cards = new List<GameObject>();
            cardSlots = new List<GameObject>();

            hasIbisEnded = false;

            _ibisA = GameObject.Find("ibisA");
            _turnBased = GameObject.Find("TurnBased");
/*
            _targetPos = GameObject.Find("Target2");
            v3_targetPos = _targetPos.transform.position;*/

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

            // _LandGen2 = GameObject.Find("LandGenerator").GetComponent<LandGen2>();

            _LandGen3 = GameObject.Find("LandGenerator").GetComponent<LandGen3>();

            _allCheck = GameObject.Find("AllCheck").GetComponent<allCheck>();

            drawCardShouldEnd = false;

            pollutionTimesEachTurn =2;
            TimesHasPolluttedEachTurn = 0;
            hasCalculateAP = false;

           // print("myTurn Start: _ibisA: " + _ibisA);
        }


        [Task]

        void genIbisA()// change its position, not gen
                       //no highHill on
                       // only the first turn on
        {
            hasSetNPCTreeActive = false;


            // use Map.Instance. xxx to find obj on lands 
            // Map.instance.itemAList[1] =

            //Check if something on the land
            //print("turn based: " +_turnBased.name);
            if (transform.parent.gameObject.GetComponent<turnBased>().turn == 1)// supposed to be _turnBased
            {
/*                GameObject[] lands;
                lands = GameObject.FindGameObjectsWithTag("land");*/


                List<GameObject> flatLands;
                flatLands = new List<GameObject>();

                foreach (Gird gird in Map.instance.girds)
                {
                    if (gird.state == GirdState.Null && !flatLands.Contains(gird.gameObject))
                    {
                        flatLands.Add(gird.gameObject);
                    }
                }

                int ran;
                ran = Random.Range(0, flatLands.Count - 1);

                _ibisA = GameObject.Find("ibisA");

                if (flatLands[ran] != null)
                {
                    //print("flat land: " + flatLands[ran].name);
                    //print("ibisA: " + _ibisA);
                    _ibisA.transform.position = flatLands[ran].transform.position;
                }

                _ibisA.GetComponent<objV2Pos>().thisV2 = flatLands[ran].GetComponent<genPos>().thisCo; // to avoid the isObjOnLand bug bcz ibisA's collider has been de actived.




            }
            //else { ThisTask.Succeed(); }




            ThisTask.Succeed();
        }

        [Task]
        void pollution()
        {

          
            GameObject[] grids;
            grids = GameObject.FindGameObjectsWithTag("grid");

            foreach (GameObject grid in grids)
            {
                if (_outerAI.pollutionRate > 0)   
                {
                    int ran;
                    ran = Random.Range(0, 2);
                    if (ran> 0 && TimesHasPolluttedEachTurn < pollutionTimesEachTurn )
                    {
                        if (grid.GetComponent<grid>().landType == 2 ||
                            grid.GetComponent<grid>().landType == 3 ||
                            grid.GetComponent<grid>().landType == 4 ||
                            grid.GetComponent<grid>().landType == 7)
                        {
                            grid.GetComponent<grid>().polluteThis();
                            TimesHasPolluttedEachTurn = TimesHasPolluttedEachTurn + 1;

                            print("TimesHasPolluttedEachTurn: " + TimesHasPolluttedEachTurn);
                        }
                        
                    }
                }
            }

/*
            //de active all "Snap To " of obj  under "objOnland"

            List<GameObject> objs;
            objs = new List<GameObject>();
            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {
                
                if (child.gameObject.GetComponent<SnapToNode>() )
                { child.gameObject.GetComponent<SnapToNode>().enabled = false; }
            }
           // _ibisA.GetComponent<SnapToNode>().enabled = false;


            // Recalculate the graph
             AstarPath.active.Scan();
          //  _ibisA.GetComponent<SnapToNode>().enabled = true;*/

            ThisTask.Succeed();
        }

        [Task]
        void checkPollution()  // should be draw the cards
                                       // check if all lands have polluted,
                              // -> may change the landtype
                              // -> may pollute the food(fish, crickets..)
                              // -> may reduce the quality of the food
        {

            foreach (GameObject land in _LandGen3.LandCos_GO)
            { 
                land.transform.GetChild(0).GetComponent<grid>().checkHasPolluted();
            }

            ThisTask.Succeed();
        }

        [Task]
        void NPCAct()
        {
            //active all "Snap To " of obj  under "objOnland"

            List<GameObject> objs;
            objs = new List<GameObject>();
            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {
                if (child.gameObject.GetComponent<SnapToNode>())
                { child.gameObject.GetComponent<SnapToNode>().enabled = true; }
            }
            //_ibisA.GetComponent<SnapToNode>().enabled = true;

            //_myIbis.setIsObjOnLand();

            if (!hasSetNPCTreeActive)
            {
                //gen a npc behavior tree
                GameObject npcOrder_snake = Instantiate(Resources.Load("goj/NpcOrder_snake")) as GameObject;
                npcOrder_snake.transform.SetParent(_turnBased.transform);
                npcOrder_snake.GetComponent<PandaBehaviour>().Reset();
                npcOrder_snake.GetComponent<PandaBehaviour>().enabled = true;

                //NpcOrder_egret
                GameObject npcOrder_egret = Instantiate(Resources.Load("goj/NpcOrder_egret")) as GameObject;
                npcOrder_egret.transform.SetParent(_turnBased.transform);
                npcOrder_egret.GetComponent<PandaBehaviour>().Reset();
                npcOrder_egret.GetComponent<PandaBehaviour>().enabled = false;

                //NpcOrder_trapMan
                GameObject npcOrder_trapMan = Instantiate(Resources.Load("goj/NpcOrder_trapMan")) as GameObject;
                npcOrder_trapMan.transform.SetParent(_turnBased.transform);
                npcOrder_trapMan.GetComponent<PandaBehaviour>().Reset();
                npcOrder_trapMan.GetComponent<PandaBehaviour>().enabled = false;

                hasSetNPCTreeActive = true;

                Panda.Ibis.MyNPC.end = false;

                print("gen npc ai tree");
            }
            /*            if (hasSetNPCTreeActive)
                        {
                            Destroy(_npcOrder);
                            ThisTask.Succeed();
                        }*/

            //set sprite order
                //ibisA
                _ibisA.GetComponent<spriteOrder>().adjustOrder();
                //all npc  => objOnLnad
                //all obj gened by cards => objOnLnad
                //all trap => objOnLnad
                foreach (Transform child in GameObject.Find("ObjOnLand").transform)
                    {
                    if (child.gameObject.GetComponent<spriteOrder>())
                        {
                          child.GetComponent<spriteOrder>().adjustOrder();
                        }
                    }
            //set sprite order

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
        void checkAllObjNPC() // check the changes of All NPC
                              // and check if them on the corresponding grid
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

            // check the objOnLand list, and all gameobjects under NPCs
            /*            for(int i =0; i< _listObjOnLand.isObjOnLand.Count; i++)
                        {
                            _listObjOnLand.isObjOnLand[i] = false;
                        }*/

            //0//check all obj's lastTurn
                //trap
            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {
                if (child.gameObject.name == "trap")
                {
                    child.gameObject.GetComponent<trapBreak>().reduce1LastTurn();
                    child.gameObject.GetComponent<trapBreak>().checkIfLast();
                }
            }

            //polluted gird

            GameObject[] grids;
            grids = GameObject.FindGameObjectsWithTag("grid");
            foreach (GameObject grid in grids)
            {
                if (grid.GetComponent<grid>().landType == 8)
                {
                    grid.GetComponent<grid>().reduce1LastTurn();
                    grid.GetComponent<grid>().checkIfLast();
                }
            }

            //1//check all obj's lastTurn

            for (int i =0; i<  _listObjOnLand.isObjOnLand.Count; i++)
            { _listObjOnLand.isObjOnLand[i] = false; }

            // add objs
            // may usefulless in new pathfinding arounding
            foreach (Transform obj_child in GameObject.Find("ObjOnLand").transform)
            {
                Vector2 v2_obj;
                v2_obj = obj_child.gameObject.GetComponent<objV2Pos>().thisV2;
                int index_obj;
                index_obj = _LandGen3.LandCos.IndexOf(v2_obj);
                _listObjOnLand.isObjOnLand[index_obj] = true;
            }

/*            //add ibisA and other under NPCs
            Vector2 v2_ibisA;
            v2_ibisA = _ibisA.GetComponent<objV2Pos>().thisV2;
            int index_ibisA;
            index_ibisA = _LandGen3.LandCos.IndexOf(v2_ibisA);
            _listObjOnLand.isObjOnLand[index_ibisA] = true;
            ////////////*/
            

            ///remove the trap's Rigidbody
            //foreach (Transform obj_child in GameObject.Find("ObjOnLand").transform)
            //{
            //    if (obj_child.gameObject.name == "trap")
            //    {
            //        Destroy(obj_child.gameObject.GetComponent<Rigidbody>());
            //    }
            //}

             //de active all "Snap To " of obj  under "objOnland"

/*            List<GameObject> objs;
            objs = new List<GameObject>();
            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {

                if (child.gameObject.GetComponent<SnapToNode>())
                { child.gameObject.GetComponent<SnapToNode>().enabled = false; }
            }
            //_ibisA.GetComponent<SnapToNode>().enabled = false;

            // Recalculate the graph
             AstarPath.active.Scan();*/
            

            ///// Top// check the egg // ///////
/*            if (Panda.Ibis.MyIbis.eggs.Count > 0)  // if the egg can hatch, hatch them into baby ibis
            {
                foreach (GameObject egg in Panda.Ibis.MyIbis.eggs)
                {
                    egg.GetComponent<objEgg>().checkHatch();
                }
                //Panda.Ibis.MyIbis.eggs.Clear();
            }*/
            /////End// check the egg // ///////

            ThisTask.Succeed();
        }

        [Task]
        void calculateAP()
        {
            if (!hasCalculateAP)
            {
                Panda.Ibis.MyIbis.actionPoint = 4 - Panda.Ibis.MyIbis.APreduced;

                hasCalculateAP = true;

                print("[Task]  calculateAP()");
            }
            ThisTask.Succeed();
        }


        [Task]
        void dealCards()
        {
            //_myIbis.setIsObjOnLand();
           

            if (!isGencards)
            { genCards();
                isGencards = true;
            }

            GameObject.Find("skipTurn").GetComponent<Image>().enabled = true;
            GameObject.Find("skipTurn").GetComponent<skipToNextTurn>().enabled =true;
            GameObject.Find("skipTurn").transform.GetChild(0).gameObject.SetActive(true);

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
            { cardsCanDraw = amountsCards(_outerAI.month) - 1; } //��ʱ��


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

                //

                //check if any obj or ibisA on the land
                //_allCheck.checkNpcIbisOnAllGrids();

                GameObject.Find("skipTurn").GetComponent<Image>().enabled = false;
                GameObject.Find("skipTurn").GetComponent<skipToNextTurn>().enabled = false;
                GameObject.Find("skipTurn").transform.GetChild(0).gameObject.SetActive(false);

                ThisTask.Succeed();
            }

            if (drawCardShouldEnd) // used for no place to put any cards
            {
                foreach (Transform child in _Cards.transform)
                {
                    Destroy(child.gameObject);
                }

                //check if any obj or ibisA on the land
                //_allCheck.checkNpcIbisOnAllGrids();

                GameObject.Find("skipTurn").GetComponent<Image>().enabled = false;
                GameObject.Find("skipTurn").GetComponent<skipToNextTurn>().enabled = false;
                GameObject.Find("skipTurn").transform.GetChild(0).gameObject.SetActive(false);
                ThisTask.Succeed();
            }
        }



        [Task]
        void ibisAct()
        {
            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {
                if (child.gameObject.GetComponent<CapsuleCollider>())
                { child.gameObject.GetComponent<CapsuleCollider>().enabled = false; }
            }

            //how about create 24 bools for scan in 24 turns?
            // Recalculate the graph
            //AstarPath.active.Scan();

            _ibisA.GetComponent<Animator>().enabled = true;
            _ibisA.GetComponent<Pathfinding.AILerp>().enabled = true;
            //_ibisA.GetComponent<SnapToNode>().enabled = false;  //X
            _ibisA.GetComponent<CapsuleCollider>().enabled = true;

            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {
                if (child.name == "trap")
                {
                    child.gameObject.GetComponent<CapsuleCollider>().enabled = true;
                }
            }

                if (!hasSetPandaActive)
            {
                foreach (Transform child in _ibisA.transform)
                {
                    child.gameObject.SetActive(true);

                    child.gameObject.GetComponent<PandaBehaviour>().Reset();

                }

                _ibisA.transform.GetChild(0).gameObject.GetComponent<PandaBehaviour>().enabled = true;

                GameObject.Find("ibis_begin").SetActive(true);
                GameObject.Find("ibis_begin").GetComponent<MyIbis_begin>().enabled = true;
                hasSetPandaActive = true;
            }

            //set sprite order
            //ibisA
            _ibisA.GetComponent<spriteOrder>().adjustOrder();
            //all npc  => objOnLnad
            //all obj gened by cards => objOnLnad
            //all trap => objOnLnad
            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {
                if (child.gameObject.GetComponent<spriteOrder>())
                {
                    child.GetComponent<spriteOrder>().adjustOrder();
                }
            }

            //trap -> obj-> npc -> ibisA

            //set sprite order


            ////check if AP is over during this process

             if (Panda.Ibis.MyIbis.actionPoint <= 0)
            {
                _ibisA.GetComponent<Panda.Ibis.MyIbis>().breakThisTurn();

                Debug.Log("AP = 0.");
              //  Panda.Ibis.MyIbis.breakThisTurn();
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
            _ibisA.GetComponent<Pathfinding.AILerp>().enabled = false;
            _ibisA.GetComponent<Panda.Ibis.MyIbis>().landsPassThrough.Clear();
            _ibisA.GetComponent<CapsuleCollider>().enabled = false;
            // _ibisA.GetComponent<PandaBehaviour>().enabled = false;
             _ibisA.GetComponent<SnapToNode>().enabled = true;

            foreach (Transform child in _ibisA.transform)
            {
                child.gameObject.GetComponent<PandaBehaviour>().enabled = false;
                child.gameObject.GetComponent<PandaBehaviour>().Reset();
                
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
                         // new Vector3(v3_middleCard.x - (thisAmount - 1) + i * 2f, v3_middleCard.y, v3_middleCard.z);
                         new Vector3(v3_middleCard.x, v3_middleCard.y - (thisAmount - 1) + i * 1.2f, v3_middleCard.z);

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
                  
                    GameObject card = Instantiate(Resources.Load("card1")) as GameObject;
                   
                    card.transform.position = cardSlots[k].transform.position;

                    card.transform.SetParent(_Cards.transform);
                    //card.transform.SetParent(GameObject.Find(""));

                    card.name = "card" + k.ToString();


                    //card.GetComponent<SpriteRenderer>().sprite = Resources.Load()

                    if (!cards.Contains(card))
                    { cards.Add(card); }

                    GameObject obj = Instantiate(Resources.Load("obj/obj")) as GameObject;
                    obj.transform.SetParent(card.transform);
                    obj.GetComponent<SnapToNode>().enabled = false;
                    obj.transform.position = new Vector3(999f, 999f, 999f);
                    obj.transform.localScale = new Vector3(0.65f,0.65f,0.65f);

                    //decide what this card is
/*                    int random_index;
                    random_index = Random.Range(0, _listObjOnLand.objOnLand.Count);
                    obj.name = _listObjOnLand.objOnLand[random_index];*/

                    // ��������ʱ�ģ����������
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
