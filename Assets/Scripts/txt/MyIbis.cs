using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Panda;

using DG.Tweening;


//start after drawing all the cards.

//meet obj: collider
namespace Panda.Ibis {
    public class MyIbis : MonoBehaviour
    {
        [Header(" ● Normal Properties")]
        // properties of the bird
        static public int gender;//1为雌，2为雄  // set when game starts, public is comtem...
        static public int full;// 0饿,1饱
        static public int full_max;
        static public int energy;//0 need to rest, 1 no need 
        static public bool isSingle;
        static public GameObject mate; // make sure it's double sides
        static public int actionPoint;
        static public int maxAP;

        static public bool hasBringTwig;
        static public bool hasBringLiana;

        [Header(" ● Node Structure Mark")]
        //node structure mark
        public bool isGoToOpSexSingleMeetOp;

        public bool isMeetSingleComb;
        public bool isGoToOpSexNotSingleMeetOp;
        static public bool isCourtship;
        public bool isMate;
        public bool isSpawn;
        public bool hasNest;
        public bool withFood;


        public GameObject meetToBreak;

        outerAI _outAI;

        List<GameObject> foods_l;
        List<Vector2> v2_foods_l;

        GameObject _targetPos;
        Vector3 v3_targetPos;

        listObjOnLand _listObjOnLand;

        LandGen2 _LandGen2;

        CrestedIbis _CrestedIbis;

        Vector2 v2_nearestFood;

        List<GameObject> opSexNPCIbis;

        GameObject choosenIbis; // only for moving to

        int turnsAfterSpawn; // +1 each turn until incubating


        public Animator ani;

        int monthSpawn;

        turnBased _turnBased;


        public GameObject _eat;
        public GameObject _goToOpIbis;
        public GameObject _mate;
        public GameObject _buildNest;
        public GameObject _spawn;
        public GameObject _incubate;
        public GameObject _breed;
        public GameObject _rest;

        public GameObject _dot;


        [Header("Theirtory")]
        public List<GameObject> landsPassThrough;

        /*        //test
                public List<Vector2> t2;
                public Vector2 t1;
                //test*/
        void Start()
        {
 /*           if (transform.parent.gameObject.GetComponent<Animator>())
            { print("ani exist: " + gameObject.name); }*/

            /*            t2 = new List<Vector2>();

                        t2.Add(new Vector2(1, 1));
                        t2.Add(new Vector2(-2, 1));
                        t2.Add(new Vector2(-1, 0));
                        t2.Add(new Vector2(0, -2));
                        Debug.Log("get nearest grid: " + getNearestGrid(t1, t2));*/


            /////////////Properties////////////////////
            ////////////////Properties////////////////////

            gender = 2;
            full = 0;// 0饿,1饱
            full_max = 1;
            energy = 1;//0 need to rest, 1 no need 
            isSingle = false;

            actionPoint = 7;
            maxAP = 7;

            mate = GameObject.Find("ibisC");

            hasBringTwig = false;
            hasBringLiana = false;


            /////////////Properties////////////////////
            /////////////Properties////////////////////
            ///
            /////////////Node Structure Mark////////////////////
            isGoToOpSexSingleMeetOp = false;
            isMeetSingleComb = false;
            isGoToOpSexNotSingleMeetOp = false;

            isMate = false;
            isSpawn = false;
            hasNest = false;
            withFood = false;

            /////////////Node Structure Mark////////////////////

            transform.DOScaleX(-0.75f, 0.001f);
            transform.DOScaleY(0.75f, 0.001f);


            isMate = false;
            isCourtship = false;

            _outAI = GameObject.Find("Values").GetComponent<outerAI>();


            foods_l = new List<GameObject>();
            _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();


            v2_foods_l = new List<Vector2>();

            _LandGen2 = GameObject.Find("LandGenerator").GetComponent<LandGen2>();

            _targetPos = GameObject.Find("Target2");
            v3_targetPos = _targetPos.transform.position;

            _CrestedIbis = GameObject.Find("ibisA").GetComponent<CrestedIbis>();


            opSexNPCIbis = new List<GameObject>();


            turnsAfterSpawn = 0;

            /*            if (gameObject.GetComponent<Animator>())
                        {
                            ani = gameObject.GetComponent<Animator>(); 
                        }*/

            monthSpawn = 0;

            landsPassThrough = new List<GameObject>();

            //gameObject.GetComponent<PandaBehaviour>().enabled = false;

            _turnBased = GameObject.Find("TurnBased").GetComponent<turnBased>();




        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                transform.parent.gameObject.GetComponent<Pathfinding.AILerp>().speed = 0;
                transform.parent.gameObject.GetComponent<SnapToNode>().enabled = false;
                transform.parent.gameObject.GetComponent<SnapToNode>().enabled = true;
                //防抖动，需加特效或啥，获得v2坐标，用dotween移过去
            }

            if (_turnBased.turn == 1)
            { actionPoint = landsPassThrough.Count - 1; }
            else { actionPoint = landsPassThrough.Count; }

            if (actionPoint > maxAP)
            {
                landsPassThrough.Clear();
                GetComponent<PandaBehaviour>().enabled = false;

                transform.parent.gameObject.GetComponent<Pathfinding.AILerp>().enabled = false;


                // gameObject.GetComponent<PandaBehaviour>().enabled = false;

                GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<PandaBehaviour>().Reset();
                gameObject.GetComponent<PandaBehaviour>().Reset();

                _turnBased.newTurnStart();

                Destroy(GameObject.Find("TurnBased").transform.GetChild(0).gameObject);
            }
        }


        bool isFirstHalfYear()
        {
            bool _isFirstHalfYear;
            _isFirstHalfYear = false;
            if (_outAI.month == 1 || _outAI.month == 2 || _outAI.month == 3 ||
                _outAI.month == 4 || _outAI.month == 5 || _outAI.month == 6)
            {
                _isFirstHalfYear = true;
            }
            else { _isFirstHalfYear = false; }

            return _isFirstHalfYear;
        }

        bool isLastHalfYear()
        {
            bool _isLastHalfYear;
            _isLastHalfYear = false;
            if (_outAI.month == 7 || _outAI.month == 8 || _outAI.month == 9 ||
                _outAI.month == 10 || _outAI.month == 11 || _outAI.month == 12)
            {
                _isLastHalfYear = true;
            }
            else { _isLastHalfYear = false; }

            return _isLastHalfYear;
        }


        public void setIsObjOnLand()
        {
            List<Vector2> v2_allIbils;
            v2_allIbils = new List<Vector2>();

            // v2_allIbils.Add(gameObject.GetComponent<objV2Pos>().thisV2);
            // print(gameObject.GetComponent<objV2Pos>().thisV2);
            v2_allIbils.Add(new Vector2(0f, 0f));// 设ibisA初始在正中央。因代码执行顺序原因第一次运行程序时采不到ibisA坐标
            for (int i = 0; i < _listObjOnLand.NPCibisOnLand.Count; i++)
            {
                if (!v2_allIbils.Contains(_listObjOnLand.NPCibisOnLand[i].GetComponent<objV2Pos>().thisV2))
                { v2_allIbils.Add(_listObjOnLand.NPCibisOnLand[i].GetComponent<objV2Pos>().thisV2); }
            }

            foreach (Vector2 v2 in v2_allIbils)
            {
                print(v2);
            }

            List<int> index;
            index = new List<int>();
            for (int k = 0; k < v2_allIbils.Count; k++)
            {
                int a = _LandGen2.LandCos.IndexOf(v2_allIbils[k]);
                if (!index.Contains(a))
                { index.Add(a); }
            }

            for (int p = 0; p < index.Count; p++)
            {
                _listObjOnLand.isObjOnLand[index[p]] = true;
            }

            //  ThisTask.Succeed();
        }

        [Task]
        void enableAILerp()
        {
            transform.parent.gameObject.GetComponent<Pathfinding.AILerp>().enabled = true;

            ThisTask.Succeed();
        }

        [Task]
        void checkHasFood()
        {
            GameObject[] foods2 = GameObject.FindGameObjectsWithTag("food");
            /*            _listObjOnLand.foodOnLand.Clear();
                        _listObjOnLand.foodOnLand_GO.Clear();*/

            for (int i = 0; i < foods2.Length; i++)
            {
                if (!_listObjOnLand.foodOnLand_GO.Contains(foods2[i]))
                { _listObjOnLand.foodOnLand_GO.Add(foods2[i]); }
                if (!_listObjOnLand.foodOnLand.Contains(foods2[i].GetComponent<objV2Pos>().thisV2))
                { _listObjOnLand.foodOnLand.Add(foods2[i].GetComponent<objV2Pos>().thisV2); }
                Debug.Log("which food in the scene: " + foods2[i].name);
            }

            if (foods2.Length == 0)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }


        [Task]
        void seekFood()
        {

                //seek all food obj in the scene
                v2_foods_l = new List<Vector2>(_listObjOnLand.foodOnLand);


                //寻找有食物的地点：水田、河滩，go!

                v2_nearestFood = getNearestGrid(transform.parent.gameObject.GetComponent<objV2Pos>().thisV2, _listObjOnLand.foodOnLand);
                Debug.Log("v2_nearestFood: " + v2_nearestFood + " , " + transform.parent.gameObject.GetComponent<objV2Pos>().thisV2
                    + " ,  " + v2_foods_l[0]);


                if (isFirstHalfYear())
                {
                    seekForFoodJantoJun();
                    //Debug.Log("seek food: first half year.");
                }
                if (isLastHalfYear())
                {

                    seekForFoodJuntoNov();
                    // Debug.Log("seek food: last half year.");
                }

                if (transform.parent.gameObject.GetComponent<objV2Pos>().thisV2 == v2_nearestFood) //暂
                {
                    Debug.Log("seek food succeed.");
                    ThisTask.Succeed();
                }


                // Debug.Log("speed: "+ gameObject.GetComponent<Pathfinding.AILerp>().speed);
            

        }
        void seekForFoodJantoJun()//觅食。水田里有泥鳅、田螺、黄鳝、青蛙以及软体动物。
                                  //河滩中有鱼、虾、螺、蟹及贝类等食物
        {

            //寻找最近的能量最高的上述食物，移过去

            int index_LandCos;
            index_LandCos = _LandGen2.LandCos.IndexOf(v2_nearestFood);
            //Debug.Log("index_LandCos: " + index_LandCos);

            Vector3 food_pos;
            food_pos = _LandGen2.LandV3s[index_LandCos];
            //  Debug.Log("food position: " + food_pos);

            seekLocation(food_pos);

            //....
            //如果上面没有，寻找有地点：水田、河滩，go!
            //如果有吃的,吃

            // 以上all true, succeed
        }

        void seekForFoodJuntoNov()//常见于河滩、旱地和塘库边缘（觅食地大而分散）
                                  //觅食。主要以蚯蚓、直翅目昆虫（如蟋蟀、蝼蛄）、螃蟹等为主。
        {
            //地点:河滩、旱地、塘库边缘

            //暂时的：
            int index_LandCos;
            index_LandCos = _LandGen2.LandCos.IndexOf(v2_nearestFood);
            //Debug.Log("index_LandCos: " + index_LandCos);

            Vector3 food_pos;
            food_pos = _LandGen2.LandV3s[index_LandCos];
            //  Debug.Log("food position: " + food_pos);

            seekLocation(food_pos);
        }

        [Task]
        void ifO()
        {
            print("ifO");
            ThisTask.Succeed();
        }

        [Task]
        void eat()
        {
            int amount_food;
            amount_food = _listObjOnLand.foodOnLand.Count;

  //          if (_listObjOnLand.foodOnLand_GO.Count > 0)
   //         {
                //吃
                //Destroy the food & 

                //remove it from the food list
                Vector2 v2_ibis;
                //Vector2 v2_food;
                int index_food;
                v2_ibis = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
                index_food = _listObjOnLand.foodOnLand.IndexOf(v2_ibis);

                int index2;
                index2 = _LandGen2.LandCos.IndexOf(v2_ibis);
                _listObjOnLand.isObjOnLand[index2] = false;

                full = full + _listObjOnLand.foodOnLand_GO[index_food].GetComponent<objFood>().rich;
                if (full > full_max)
                {
                    full = full_max;
                }

                //Play pick food animation
                transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("pickFood");


            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasFood"))
            {
                
                Destroy(_listObjOnLand.foodOnLand_GO[index_food]);
                _listObjOnLand.foodOnLand_GO.Remove(_listObjOnLand.foodOnLand_GO[index_food]);
                _listObjOnLand.foodOnLand.Remove(v2_ibis);
                print("has food..");

                if (_listObjOnLand.foodOnLand.Count < amount_food)
                {
                    print(" < original food amount.");
                    lightEat();
                    ThisTask.Succeed();
                }
            }



                /*            if (ani.GetBool("hasFood"))
                            { ThisTask.Succeed(); }*/
   //         }
/*            if (_listObjOnLand.foodOnLand_GO.Count <= 0)
            {
              
                ThisTask.Fail();
            }*/
        }


        [Task]

        void isFemale()
        {
            if (gender == 1) //雄
            { ThisTask.Succeed(); } 
            else { ThisTask.Fail(); }
        
         }

        [Task]
        void isMale()
        {
            if (gender == 2)
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }

        }

        [Task]
        void isThisSingle()
        {
            if (isSingle) 
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }

        [Task]
        void isThereNPCIbis()
        {
            if (_listObjOnLand.NPCibisOnLand.Count > 0)
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }


        [Task]
        void isThereOpGender()
        {
            /*            int test;
                        test = 1;
                        if (test == 1)
                        {
                            ThisTask.Succeed();
                        }*/

            int amount;
            amount = 0;
            for (int i = 0; i < _listObjOnLand.NPCibisOnLand.Count; i++)
            {
                if (_listObjOnLand.NPCibisOnLand[i].GetComponent<NPCIbis>().gender != gender)
                {
                    print(i + " npc: " + _listObjOnLand.NPCibisOnLand[i].GetComponent<NPCIbis>().gender +" , this gender: " + gender);
                    amount = amount + 1;
                }
            }

            if (amount > 0) { ThisTask.Succeed(); } else { ThisTask.Fail(); }

        }


        [Task]
        void isThereSingleOpGender()
        {
            int amount;
            amount = 0;
            List<GameObject> allOpGenderOp;
            allOpGenderOp = new List<GameObject>();

            for (int i = 0; i < _listObjOnLand.NPCibisOnLand.Count; i++)
            {
                if (_listObjOnLand.NPCibisOnLand[i].GetComponent<NPCIbis>().gender != gender)
                {
                    if (_listObjOnLand.NPCibisOnLand[i].GetComponent<NPCIbis>().isSingle)
                    { amount = amount + 1;
                        if (!allOpGenderOp.Contains(_listObjOnLand.NPCibisOnLand[i]))
                        {
                            allOpGenderOp.Add(_listObjOnLand.NPCibisOnLand[i]);
                        }
                    }
                    
                }
            }

            int ran;
            ran = Random.Range(0, allOpGenderOp.Count);
            choosenIbis = allOpGenderOp[ran];
            print("choosen Ibis: " +choosenIbis);

            if (amount > 0) { ThisTask.Succeed(); } else { ThisTask.Fail(); }
        }

        [Task]
        void goToOpGender()
        {
            seekLocation(choosenIbis.transform.position);

            Vector2 v2_ibisB;
            Vector2 v2_ibisA;
            v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
            v2_ibisB = choosenIbis.GetComponent<objV2Pos>().thisV2;

            Debug.Log("end: " + choosenIbis.name);

            if (v2_ibisA == v2_ibisB)//ibisA reach ibisB
            {
                Debug.Log("end4.");

                lightGoToOpIbis();
                ThisTask.Succeed();
            }
        }

        [Task]
        void isPartnerOnTheMap()
        {
            if (mate)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void isThisCourtship()
        {

            if (isCourtship)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void Courtship()
        {
            // play ani
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_courtship");

            Debug.Log("courtship.");
            //after playing the ani, task succeed
            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasCourtship"))
            {
                Debug.Log("meet5.");


                isSingle = false;

                choosenIbis.GetComponent<NPCIbis>().isSingle = false;
                choosenIbis.GetComponent<NPCIbis>().mate = transform.parent.gameObject;

                choosenIbis.transform.GetChild(0).GetComponent<getInfo>().ResetProperties();

                isSingle = false;
                mate = choosenIbis;

                isCourtship = true;
                ThisTask.Succeed();
            }
        }

        [Task]
        void goToMate()
        {
            seekLocation(mate.transform.position);

            Vector2 v2_ibisB;
            Vector2 v2_ibisA;
            v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
            v2_ibisB = mate.GetComponent<objV2Pos>().thisV2;

            Debug.Log("going to mate: " + mate.name);

            if (v2_ibisA == v2_ibisB)//ibisA reach ibisB
            {
                Debug.Log("reach to mate.");

                ThisTask.Succeed();
            }
        }

        [Task]
        void Mate()
        {
            // play mate ani (egg)
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_produceEggs");

            //Succeed
            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasProducedEggs"))
            {
                mate.GetComponent<NPCIbis>().isMate = true;
                mate.GetComponent<NPCIbis>().mate = transform.parent.gameObject;

                lightMate();

                actionPoint = actionPoint + 1;

                isMate = true;
                ThisTask.Succeed();
            }

        }

        [Task]
        void goToOpSex()
        {
            bool isNoOtherNPCIbis;
            isNoOtherNPCIbis = false;

            // GameObject targetIbis;

            int ran_index;
            ran_index = -1;

            //print("1");
            if (gender == 2)
            {
                //print("2");
                if (isSingle)
                {
                   // print("3");
                    //if an op sex ibis
                    if (_listObjOnLand.NPCibisOnLand.Count > 0)
                    {
                        bool allSameSex;
                        allSameSex = true;

                        bool allSingle;
                        allSingle = true;
                        int am_single;
                        am_single = 0;

                      //  print("4");
                        for (int i = 0; i < _listObjOnLand.NPCibisOnLand.Count; i++)
                        {
                            if (_listObjOnLand.NPCibisOnLand[i].GetComponent<NPCIbis>().gender == 1)//若为雌
                            {
                                /*                               foreach (GameObject goj in opSexNPCIbis)
                                                               {
                                                                   print(goj.name);
                                                               }*/
                                allSameSex = false;

                              //  print("5");
                                if (!opSexNPCIbis.Contains(_listObjOnLand.NPCibisOnLand[i]))//添加进雌性list
                                {
                                  //  print("6");
                                    opSexNPCIbis.Add(_listObjOnLand.NPCibisOnLand[i]);
                                    //  Debug.Log("end1. count: " + _listObjOnLand.NPCibisOnLand.Count);


                                    ran_index = Random.Range(0, opSexNPCIbis.Count);
                                    // targetIbis = opSexNPCIbis[ran_index];
                                    if (opSexNPCIbis[ran_index].GetComponent<NPCIbis>().isSingle)
                                    {
                                      //  print("7");
                                       am_single = am_single+1;

                                        if (ran_index > -1)
                                        {
                                        //    print("8");
                                            choosenIbis = opSexNPCIbis[ran_index];
                                           // choosenIbis.GetComponent<NPCIbis>().isSingle = false;

                                            Debug.Log("end1, " + "which ibis NPC : " + ran_index + " , " + opSexNPCIbis.Count + " , " + opSexNPCIbis[ran_index]);
                                            // isNoOtherNPCIbis = false;
                                        }
                                    }
                                    else
                                    {
/*                                        allSingle = true;
                                        print("all single");*/
                                       // isNoOtherNPCIbis = true;
                                    }

                                }
                                if (opSexNPCIbis.Contains(_listObjOnLand.NPCibisOnLand[i]))
                                {
                                    am_single = am_single + 1;
                                }

                            }
                            else//若其中一只为同性 
                            {
                                //nothing happens
                            }
                        }
                        if (choosenIbis == null)
                        {
                            isNoOtherNPCIbis = true;
                            print("no other NPC ibis");
                        }
                        //choose one op sex ibis

                        //get pos of this ibis

                        if (allSameSex)
                        {
                            isNoOtherNPCIbis = true;
                            print("all same sex");
                            ThisTask.Fail();
                        }

                        print("amount of single: " + am_single);
                        if (am_single == 0)
                        { allSingle = true; }
                        else { allSingle = false; }

                        if (allSingle)
                        {
                            print("all single");
                            isNoOtherNPCIbis = true;
                            ThisTask.Fail(); 
                        }
                    }
                    else
                    {
                        Debug.Log("no other NPC ibis.");
                        isNoOtherNPCIbis = true;

                        ThisTask.Fail();
                    }
                }
                else // this ibis is not single
                {
                    Debug.Log(" THIS ibis is not single.");
                    if (_listObjOnLand.NPCibisOnLand.Count > 0)
                    {
                        bool allSameSex;
                        allSameSex = true;

                        for (int i = 0; i < _listObjOnLand.NPCibisOnLand.Count; i++)
                        {

                            if (_listObjOnLand.NPCibisOnLand[i].GetComponent<NPCIbis>().gender ==1)//若为异性
                            {
                                allSameSex = false;
                                opSexNPCIbis.Add(_listObjOnLand.NPCibisOnLand[i]);
                                //  Debug.Log("end1. count: " + _listObjOnLand.NPCibisOnLand.Count);

                                ran_index = Random.Range(0, opSexNPCIbis.Count);
                                // targetIbis = opSexNPCIbis[ran_index];


                                if (ran_index > -1)
                                {

                                    choosenIbis = opSexNPCIbis[ran_index];

                                    //  Debug.Log("end2, " + "which ibis NPC : " + ran_index + " , " + opSexNPCIbis.Count + " , " + opSexNPCIbis[ran_index]);

                                    isGoToOpSexNotSingleMeetOp = true;
                                }

                            }
                            else //若其中一只为同性 
                            {
                                //nothing happens
                            }
                        }
                        if (allSameSex)
                        {
                            print("not S: all same sex");
                            isNoOtherNPCIbis = true;
                            ThisTask.Fail();
                        }

                    }
                    else// not single, no other ibis on the map 
                    {
                        print("not S:all same sex");
                        isNoOtherNPCIbis = true;
                        ThisTask.Fail(); }
                }
            }

            if (gender == 1)
            {

            }

            if (!isNoOtherNPCIbis)
            {
                //Refresh the NPC ibis info
                foreach (GameObject ibis in _listObjOnLand.NPCibisOnLand)
                {
                    ibis.transform.GetChild(0).gameObject.GetComponent<getInfo>().ResetProperties();
                }

                seekLocation(choosenIbis.transform.position);

                Vector2 v2_ibisB;
                Vector2 v2_ibisA;
                v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
                v2_ibisB = choosenIbis.GetComponent<objV2Pos>().thisV2;

                Debug.Log("end3: " + choosenIbis.name);

                choosenIbis.transform.GetChild(0).gameObject.GetComponent<getInfo>().ResetProperties();

                if (v2_ibisA == v2_ibisB)//ibisA reach ibisB
                {
                    Debug.Log("end4.");
                    isGoToOpSexSingleMeetOp = true;

                    lightGoToOpIbis();
                    ThisTask.Succeed();
                }

            }

            if (isNoOtherNPCIbis)
            {
                //  print("end5");

                // lightGoToOpIbis();
                // ThisTask.Succeed();
                ThisTask.Fail();
            }
/*            if (isGoToOpSexNotSingleMeetOp)///???
            {
                //print("end6");

                lightGoToOpIbis();
                ThisTask.Succeed(); 
            }*/

        }


        [Task]
        void actAfterMeetOpSex() // for courtship after reach this ibis
        {
            if (choosenIbis != null)
            {
                //Debug.Log("meet1. choosenibis: " +  choosenIbis.name);

                Vector2 ori_ibis;
                ori_ibis = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;

                if (choosenIbis.GetComponent<NPCIbis>().isSingle)
                {
                    // Debug.Log("meet2.");
                    if (isSingle)
                    {
                        //   Debug.Log("meet3.");
                        //set THIS ibis and its mate not single



                        // play ani
                        transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_courtship");

                           Debug.Log("meet4.");
                        //after playing the ani, task succeed
                        if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasCourtship"))
                        {
                            Debug.Log("meet5.");

                            choosenIbis.GetComponent<NPCIbis>().isMate = true;
                            choosenIbis.GetComponent<NPCIbis>().mate = transform.parent.gameObject;
                            choosenIbis.GetComponent<NPCIbis>().isSingle = false;
                            choosenIbis.transform.GetChild(0).GetComponent<getInfo>().ResetProperties();

                            isSingle = false;
                            Panda.Ibis.MyIbis.mate = choosenIbis;


                            isCourtship = true;
                            ThisTask.Succeed();
                        }
                    }
/*                    if (!isSingle && MyIbis.mate == choosenIbis)
                    {
                        // play the courtship ani
                        //ani.Play("ibis_courtship");
                        // ?--> mate ?
                        isCourtship = true;


                        //after playing the ani, task succeed
                        *//*                            if (ani.GetBool("hasCourtship"))
                                                    {
                                                        ThisTask.Succeed();
                                                    }*//*
                    }*/

                }

                if (!choosenIbis.GetComponent<NPCIbis>().isSingle && choosenIbis.GetComponent<NPCIbis>().mate != transform.parent.gameObject)  //与情敌在同一地方时
                {
                    if (choosenIbis.GetComponent<NPCIbis>().mate &&
                        choosenIbis.GetComponent<NPCIbis>().mate.GetComponent<objV2Pos>().thisV2 == gameObject.GetComponent<objV2Pos>().thisV2)
                    {
                    // play the battle ani
                    // some properties reduces
                    // go to a nearby grid

                    Vector2 nearby;
                    float n1; n1 = Random.Range(-1, 1);
                    float n2; n2 = Random.Range(-1, 1);
                    nearby = new Vector2(ori_ibis.x + n1, ori_ibis.y + n2);

                    Debug.Log("not single, and then love rivail is here too, go nearby.");

                    seekLocation(nearby);

                    if (transform.parent.gameObject.GetComponent<objV2Pos>().thisV2 == nearby)
                    {
                        ThisTask.Succeed();
                    }
                    }
                }
            }

            if (choosenIbis == null)
            {
                ThisTask.Fail();
            }

        }

        [Task]
        void checkIsCourtship()
        {
            if (!isCourtship)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void mateWith()
        {
            if (isCourtship)
            {
                // play produce ani (egg)
                transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_produceEggs");

                //Succeed
                if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasProducedEggs"))
                {
                    lightMate();

                    isMate = true;
                    ThisTask.Succeed();
                }

            }
            if (!isCourtship)
            {
                //Succeed
                ThisTask.Succeed();
            }
        }

        [Task]
        void comb()
        {
                //play the ani
                transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_comb");
                // //after playing the ani, task succeed
                if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasCombed"))
                {
                    //once success, 
                   // isMeetSingleComb = true;
                    Debug.Log("comb!");

                    ThisTask.Succeed();
                }

        }

        [Task]
        void touchBeaks()  // combo for combing??!
        {
                //both birds play the ani 
                transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_touchedBeaks");
                // choosenIbis.GetComponent<Animator>().Play("ibis_touchedBeaks"); // 需要较位

                if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasTouchedBeaks"))
                {
                    Debug.Log("touch beaks.");
                    ThisTask.Succeed();
                }

           
        }

        [Task]
        void quarrelWithLoveRival()
        {
            Debug.Log("qua0");
            if (isGoToOpSexNotSingleMeetOp)
            {
                //play quarrel ani
                transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_quarrel");
                Debug.Log("qua1");
                //ani end, bool unlocked
                if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasQuarrelled"))
                {
                    Debug.Log("qua2");
                    ThisTask.Succeed(); }
            }
            if (!isGoToOpSexNotSingleMeetOp)
            { ThisTask.Succeed(); }
        }

        [Task]
        void buildNest_a() //abandoned
        {
            /*//go to near the place which can have food
                    List<GameObject> gridsRichFood;
                    List<GameObject> gridsLittleFood;
                    gridsRichFood = new List<GameObject>();
                    gridsLittleFood = new List<GameObject>();

                    List<Vector2> v2_gridsRichFood;
                    List<Vector2> v2_gridsLittleFood;
                    v2_gridsRichFood = new List<Vector2>();
                    v2_gridsLittleFood = new List<Vector2>();


                    GameObject[] allGrids = GameObject.FindGameObjectsWithTag("grid");
                    for (int i = 0; i < allGrids.Length; i++)
                    {
                        if (allGrids[i].GetComponent<grid>().canRichFood)
                        {
                            gridsRichFood.Add(allGrids[i]);

                            Vector2 v2;
                            v2 = allGrids[i].transform.parent.GetComponent<genPos>().thisCo;
                            v2_gridsRichFood.Add(v2);
                        }
                        if (allGrids[i].GetComponent<grid>().canPoorFood)
                        {
                            gridsLittleFood.Add(allGrids[i]);

                            Vector2 v2;
                            v2 = allGrids[i].transform.parent.GetComponent<genPos>().thisCo;
                            v2_gridsLittleFood.Add(v2);
                        }
                    }
                    //先判定rich,在判定little
                    //如果有N个以上的食物的话，将所有点的组合遍历一遍，找N个最近的带食物的点， M个点加起来距离相差绝对值最小的点筑巢
                    //Vector2 v2_thisIbis;

                    int checkHowManyFoods;
                    if (_listObjOnLand.foodOnLand.Count >= 3)
                    { checkHowManyFoods = 3; }
                    if (_listObjOnLand.foodOnLand.Count < 3 && _listObjOnLand.foodOnLand.Count >=2)
                    { checkHowManyFoods = 2; }
                    if (_listObjOnLand.foodOnLand.Count < 2 && _listObjOnLand.foodOnLand.Count >= 1)
                    { checkHowManyFoods = 1; }

                    //for (int k=0; int <)*/





            //if succeed, hasNest = true;
        }

        [Task]
        void checkMateIbis()
        {
            if (isMate)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void checkNest()// to check if there is no nest
        {
            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");
            if (nests.Length > 0)
            { ThisTask.Fail(); }
            else { ThisTask.Succeed(); }
        }

        [Task]
        void checkHasBuidlingMaterial()
        {
/*            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");*/

            if (hasBringLiana || hasBringTwig)
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }

        [Task]
        void checkMaterialOnMap()
        {
            GameObject[] materials;
            materials = GameObject.FindGameObjectsWithTag("material");  

            if (materials.Length > 0)
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }

        [Task]
        void goToMaterial()
        {
            GameObject[] materials;
            materials = GameObject.FindGameObjectsWithTag("material");

            if (materials.Length > 0)
            {
                int ran;
                ran = Random.Range(0, materials.Length - 1);

                seekLocation(materials[ran].transform.position);

                Vector2 v2_material;
                Vector2 v2_ibisA;
                v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
                v2_material = materials[ran].GetComponent<objV2Pos>().thisV2;

                Debug.Log("going to material: " + materials[ran].name);

                if (v2_ibisA == v2_material)//ibisA reach the nest
                {
                    Debug.Log("reach to a material.");

                    if (materials[ran].name == "twig") { hasBringTwig = true; }
                    if (materials[ran].name == "liana") { hasBringLiana = true; }

                    ThisTask.Succeed();
                }
            }


        }


        [Task]
        void goToNest()
        {
            // go to the nest. There can only have one nest in the scene.
            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");

            int ran;
            ran = Random.Range(0, nests.Length-1);

            seekLocation(nests[ran] .transform.position);

            Vector2 v2_nest;
            Vector2 v2_ibisA;
            v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
            v2_nest = nests[ran].GetComponent<objV2Pos>().thisV2;

            Debug.Log("going to nest: " + nests[ran].name);

            if (v2_ibisA == v2_nest)//ibisA reach the nest
            {
                Debug.Log("reach to a nest.");

                ThisTask.Succeed();
            }

        }

        [Task]
        void buildNest()
        {

            // play the build ani
            //both birds play the ani 
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_build");
            // choosenIbis.GetComponent<Animator>().Play("ibis_touchedBeaks"); // 需要较位

            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasBuild"))
            {

                //change the nest's properties

                //after finishing it , unlock the bool, succeed


                lightBuildNest();
                Debug.Log("build a nest.");
                ThisTask.Succeed();
            }

        }

        /*        [Task]
                void checkCanSpawn()
                {
                    GameObject[] nests;
                    nests = GameObject.FindGameObjectsWithTag("nest");
                    if (nests.Length == 0 || !isMate || gender == 2)
                    {
                        ThisTask.Succeed();
                    } else { ThisTask.Fail(); }


                }*/

        [Task]
        void hasMate()
        {
            if (isMate)
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }

        [Task]
        void spawn()
        {

            if (GameObject.Find("nest") && isMate)
            {
                // seek for the nest
                seekLocation(GameObject.Find("nest").transform.position); // the nest GameObject muts be called "nest"

                List<GameObject> eggs;
                eggs = new List<GameObject>();
                int ini_count_egg;

                GameObject[] arr_eggs = GameObject.FindGameObjectsWithTag("egg");
                for (int i = 0; i < arr_eggs.Length; i++)
                {
                    eggs.Add(arr_eggs[i]);
                }
                ini_count_egg = eggs.Count;


                Vector2 v2_ibisA;
                Vector2 v2_nest;
                v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
                v2_nest = GameObject.Find("nest").GetComponent<objV2Pos>().thisV2;

                print("spawn 1, nest v2: " + v2_nest);

                int ran_amounts_egg;
                ran_amounts_egg = -1;
                if (v2_nest == v2_ibisA && _outAI.month == 3)
                {
                    print("spawn 2");
                    List<int> ran;
                    ran = new List<int>();
                    ran.Add(1); ran.Add(2); ran.Add(3); ran.Add(3); ran.Add(3); ran.Add(4);
                    ran_amounts_egg = ran[Random.Range(0, ran.Count)];
                    if (!isSpawn)
                    {
                        for (int k = 0; k < ran_amounts_egg; k++)
                        {
                            // play produce ani * ran_amounts_egg
                            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_produceEggs");

                            // eggs + new eggs(List)
                            GameObject egg = Instantiate(Resources.Load("egg")) as GameObject;
                            egg.name = "egg" + k.ToString();
                            egg.transform.position = transform.parent.gameObject.transform.position;
                            egg.transform.SetParent(GameObject.Find("ObjOnLand").transform);
                            if (k == ran_amounts_egg - 1)
                            {
                                isSpawn = true;
                            }
                        }
                    }
                    // isSpawn = true;
                    print("spawn 2-2");
                }

                if (eggs.Count == ran_amounts_egg && ran_amounts_egg > -1)
                {
                    lightSpawn();
                    print("spawn 3");
                    monthSpawn = _outAI.month;
                    ThisTask.Succeed();
                }

            }

            if (!GameObject.Find("nest"))
            {

                ThisTask.Succeed();
            }

            if (_outAI.month != 3)
            {
                ThisTask.Succeed();
            }
        }


        [Task]
        void checkCanIncubate()
        {                                    //添加check并且巢内有没有父母一方是主角ibis的幼鸟
            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");
            if (nests.Length == 0)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void incubate() //?????
        {
            if (isSpawn && _outAI.month == monthSpawn + 1)
            {
                print(" isSpawn.");
                // 产卵后1个月执行
                /*                if (turnsAfterSpawn >= 2)
                                {*/
                seekLocation(GameObject.Find("nest").transform.position);
                //just stay there, play ani
                transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_incubate");
                // egg's properties change. (And eggs are their own "branches")

                //    }
                // finished the ani, succeed
                if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasIncubated"))
                {
                    lightIncubate();
                    print(" isSpawn.");
                    ThisTask.Succeed();
                }

            }
            if (!isSpawn)
            {
                print("! isSpawn.");
                ThisTask.Succeed();
            }

        }


        [Task]
        void checkCanBreed()
        {
            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");
            if (nests.Length == 0)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void breed1()  //go to food
        {
            Vector2 v2_nearest_food;
            v2_nearest_food = getNearestGrid
                                        (GameObject.Find("nest").GetComponent<objV2Pos>().thisV2, _listObjOnLand.foodOnLand);
            Vector3 v3_nearest_food;
            for (int i = 0; i < _LandGen2.LandCos.Count; i++)
            {
                if (v2_nearest_food == _LandGen2.LandCos[i])
                {
                    v3_nearest_food = _LandGen2.LandV3s[i];
                    seekLocation(v3_nearest_food);

                    //play ani// 
                    transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_walk");

                }
            }

            if (transform.parent.gameObject.GetComponent<objV2Pos>().thisV2 == v2_nearest_food) // s b arrive the land with food
            { ThisTask.Succeed(); }
        }

        [Task]
        void breed1_5()//pick the food
        {
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("pickFood");
            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasFood"))
            {
                withFood = true;
                ThisTask.Succeed();
            }
        }

        [Task]
        void breed2()// go back to the nest with food
        {
            if (GameObject.Find("nest"))
            { seekLocation(GameObject.Find("nest").transform.position); }

            if (GameObject.Find("nest").GetComponent<objV2Pos>().thisV2
                == transform.parent.gameObject.GetComponent<objV2Pos>().thisV2)
            {
                ThisTask.Succeed();
            }
        }

        [Task]
        void breed3()///feed the baby bird
        {
            // play the ani
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_feedBaby");

            // baby birds' properties change

            //finished the ani, unlock bool, succeed
            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasFeedBaby"))
            {
                lightBreed();
                ThisTask.Succeed();
            }
        }

        [Task]
        void checkCanRest()        // go to nest
        {
            /*                if (GameObject.Find("nest"))
                            { seekLocation(GameObject.Find("nest").transform.position); }

                            if (GameObject.Find("nest").GetComponent<objV2Pos>().thisV2
                                      == transform.parent.gameObject.GetComponent<objV2Pos>().thisV2)
                            {
                                ThisTask.Succeed();
                            }*/

            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");
            if (nests.Length == 0 )
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }

        }

        [Task]
        void rest1()// go to the nest
        {
            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");

            int ran_index;
            ran_index = Random.Range(0, nests.Length);
            Vector3 v3_ranNest;
            v3_ranNest = nests[ran_index].transform.position;
            seekLocation(v3_ranNest);

            Vector2 v2_nest;
            v2_nest = nests[ran_index].GetComponent<objV2Pos>().thisV2;

            if (transform.parent.gameObject.GetComponent<objV2Pos>().thisV2 == v2_nest)
            { ThisTask.Succeed(); }
                
        }

        [Task]
        void rest2()
        {
            //play sleep ani
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_rest");

            //properties changes

            // after perproties changes, succeed
            // and this turn finished
            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasRest"))
            {
                lightRest();
                ThisTask.Succeed();
            }

        }

        [Task]
        void endTurn()
        {
            quenchAllBeBar();
            //end this turn 
            _targetPos.transform.position = v3_targetPos;

            GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<Panda.Ibis.MyTurn>().hasIbisEnded = true;
            // gameObject.GetComponent<PandaBehaviour>().enabled = false;

            //?should be destroyed after this turn?
            ThisTask.Succeed();
        }









        [Task]
        void Next()
        {
            print("next");

            GameObject nextChild;
            nextChild = null;

            for (int i = 0; i < transform.parent.childCount; i++)
            {
                if (transform.parent.GetChild(i).gameObject == gameObject)
                {
                    nextChild = transform.parent.GetChild(i + 1).gameObject;
                }
            }

            gameObject.GetComponent<PandaBehaviour>().enabled = false;
            nextChild.GetComponent<PandaBehaviour>().enabled = true;
            nextChild.GetComponent<PandaBehaviour>().Reset();
            nextChild.GetComponent<Panda.Ibis. MyIbis>().enabled = true;

            gameObject.GetComponent<Panda.Ibis.MyIbis>().enabled = false;

            ThisTask.Succeed();
        }

        ///////////SSSSSS////////Basic Element  Action Pools/////////////////////////
        ///       /////////////////////////Basic Element  Action Pools/////////////////////////
        ///              /////////////////////////Basic Element  Action Pools/////////////////////////
        ///              

        void seekLocation(Vector3 destination)
        {
            _targetPos.transform.DOMove(destination, 0.000001f, false);
            // go 
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_walk");
            _CrestedIbis.ibisMove1();

          //  Debug.Log("move to destination: " + destination);


        }





        /////////////EEEEEEEE////////////Basic Element  Action Pools/////////////////////////
        ///       /////////////////////////Basic Element  Action Pools/////////////////////////








        /////////////SSSSSSSSS////////////Gears/////////////////////////
        ///       /////////////////////////Gears/////////////////////////
        void breakWhenMoving()//用这个打断，然后去做一些事情，原理是move the Target
                                            //但是恢复打断时，要将target放回原来的地方去
                                            //
        {
            Vector3 v3_current;
            v3_current = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;

            _targetPos.transform.DOMove(v3_current,0.001f,false);
            _CrestedIbis.ibisMove1();

            Debug.Log("breaking");
        }



        Vector2 geFarthestGrid(Vector2 ori_v2, List<Vector2> v2s) 
            // actually the farthest
            // from a point A and a group of points, knowing the nearest point to point A.
        {
            Vector2 _getFarthestGrid;
            _getFarthestGrid = new Vector2();

            List<float> xs;
            List<float> ys;
            xs = new List<float>();
            ys = new List<float>();

            float x_max; x_max = 0;
            float y_max; y_max = 0;

            int index_x; index_x = -1;
            int index_y; index_y = -1;

           // Debug.Log("1");

            for (int i = 0; i < v2s.Count; i++)
            {
               xs.Add( Mathf.Abs( v2s[i].x - ori_v2.x));
                //Debug.Log(i+ ": " + Mathf.Abs(v2s[i].x - ori_v2.x));
               ys.Add( Mathf.Abs( v2s[i].y - ori_v2.y));

            }

            //Debug.Log("2");

            //然后在xs 和ys里所有的数里找绝对值最大的
            for (int j = 0; j < xs.Count; j++)
            {
                if (j == 0)
                {
                    x_max = xs[j];
                    index_x = 0;
                }
                if (j != 0)
                {
                    if (xs[j] >= x_max) { x_max = xs[j]; index_x = j; }
                }
            }

           // Debug.Log("3");

            for (int k = 0; k < ys.Count; k++)
            {
                if (k == 0)
                {
                    y_max = ys[k];
                    index_y = 0;
                }
                if (k != 0)
                {
                    if (ys[k] >= y_max) { y_max = ys[k]; index_y = k; }
                }
            }

            //Debug.Log("4");

            if (x_max >= y_max) { _getFarthestGrid = v2s[index_x]; }
            if (y_max >= x_max) { _getFarthestGrid = v2s[index_y]; }

           // Debug.Log("5");
            return _getFarthestGrid;
        }

        Vector2 getNearestGrid(Vector2 ori_v2, List<Vector2> v2s)     //still have a problem , two equal value?
        // actually the far..est
        // from a point A and a group of points, knowing the nearest point to point A.
        {
            Vector2 _getNearestGrid;
            _getNearestGrid = new Vector2();

            List<float> xs;
            List<float> ys;
            xs = new List<float>();
            ys = new List<float>();

            float x_min; x_min = 0;
            float y_min; y_min = 0;

            int index_x; index_x = -1;
            int index_y; index_y = -1;

            // Debug.Log("1");

            for (int i = 0; i < v2s.Count; i++)
            {
                xs.Add(Mathf.Abs(v2s[i].x - ori_v2.x));
                //Debug.Log(i+ ": " + Mathf.Abs(v2s[i].x - ori_v2.x));
                ys.Add(Mathf.Abs(v2s[i].y - ori_v2.y));

            }

            //Debug.Log("2");

            //然后在xs 和ys里所有的数里找绝对值最大的
            for (int j = 0; j < xs.Count; j++)
            {
                if (j == 0)
                {
                    x_min = xs[j];
                    index_x = 0;
                }
                if (j != 0)
                {
                    if (xs[j] <= x_min) { x_min = xs[j]; index_x = j; }
                }
            }

            // Debug.Log("3");

            for (int k = 0; k < ys.Count; k++)
            {
                if (k == 0)
                {
                    y_min = ys[k];
                    index_y = 0;
                }
                if (k != 0)
                {
                    if (ys[k] <= y_min) { y_min = ys[k]; index_y = k; }
                }
            }

            //Debug.Log("4");

            if (x_min <= y_min) { _getNearestGrid = v2s[index_x]; }
            if (y_min <= x_min) { _getNearestGrid = v2s[index_y]; }

            // Debug.Log("5");
            return _getNearestGrid;
        }


        //!!!set them all false when starting.
        public  void stopAni()
        {
            GetComponent<Panda.Ibis.MyIbis>().ani.enabled = false;
        }

        public void setHasFood()
        {
            GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasFood", true);
            Debug.Log("set has picked food true.");
        }
        public void setHasBuild()
        {
           GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasBuild", true); 
        }

        public void setHasWalked()
        {
            GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasWalked", true);
          // ani.SetBool("hasWalked", false);
        }
        public void setHasCombed()
        {
           GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasCombed", true);
        }

        public void setHasRest()
        {
            GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasRest", true);

        }

        public void setCourtship()
        {
            GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasCourtship", true);
        }

        public void setHasQuarrelled()
        {
            GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasQuarrelled", true);
        }

        public void setHasProducedEggs()
        {
           GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasProducedEggs", true);
        }

        public void setHasTouchedBeaks()
        {
            GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasTouchedBeaks", true); // need two Animators attached to myibis and NPCibis
        }

        public void setHasIncubated()
        {
            GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasIncubated", true);
        }

        public void setHasFeedBaby()
        {
            GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasFeedBaby", true);
        }



        //////Start///////Set BeBar/////////////////////
        //////Start///////Set BeBar/////////////////////
        void lightEat()
        {
            _eat.SetActive(true);
            _dot.transform.DOLocalMoveX(-500f, 1f);
        }

        void lightGoToOpIbis()
        {
            _goToOpIbis.SetActive(true);
            _dot.transform.DOLocalMoveX(-290f, 1f);
        }

        void lightMate()
        {
            print("lightMate.");

            _mate.SetActive(true);
            _dot.transform.DOLocalMoveX(-95f, 1f);
        }

        void lightBuildNest()
        {
            _buildNest.SetActive(true);
            _dot.transform.DOLocalMoveX(108f, 1f);
        }

        void lightSpawn()
        {
            _spawn.SetActive(true);
            _dot.transform.DOLocalMoveX(305f, 1f);
        }

        void lightIncubate()
        {
            _incubate.SetActive(true);
            _dot.transform.DOLocalMoveX(510f, 1f);
        }

        void lightBreed()
        {
            _breed.SetActive(true);
            _dot.transform.DOLocalMoveX(715f, 1f);
        }

        void lightRest()
        {
            _rest.SetActive(true);
            _dot.transform.DOLocalMoveX(915f, 1f);
        }

        void quenchAllBeBar()
        {
            _eat.SetActive(false );
            _goToOpIbis.SetActive(false);
            _mate.SetActive(false);
            _buildNest.SetActive(false);
            _spawn.SetActive(false);
            _incubate.SetActive(false);

            _dot.transform.DOLocalMoveX(-916f, 1f);
        }

        //////End///////Set BeBar/////////////////////
        //////End///////Set BeBar/////////////////////



        /// <summary>
        /// /////////////////
        /// </summary>
        /// <param name="test"></param>
        [Task]
    void seekLocationT(Vector3 destination)
    {
/*            //if (bool 条件)
            // go 
            string _test;
            _test = test;

            Debug.Log(_test);

            if (_test == "yes")
            { ThisTask.Succeed(); }*/

            ////////////////
              _targetPos.transform.DOMove(destination, 0.000001f, false);
            // go 
            _CrestedIbis.ibisMove1();

            Debug.Log("move to destination 1: " + destination);

    }




        [Task] // <-- Attribute used to tag a class member as a task implementation.
        void SetColor(float r, float g, float b)
        {
            this.GetComponent<Renderer>().material.color = new Color(r, g, b);
            ThisTask.Succeed(); // <-- ThisTask gives access to the run-time task bind to this method.
        }





        [Task]
        bool isHaveFood()
        {
            bool _isHaveFood;
            _isHaveFood = true;
            return _isHaveFood;
        }

        [Task]
        bool isNested()
        {
            bool _isNested;
            _isNested = true;
            return _isNested;
        }

    }
}


