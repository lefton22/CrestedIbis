using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Panda;

using Pathfinding;

using DG.Tweening;



//start after drawing all the cards.

//meet obj: collider


// new pathfinding refine:
// re write all stuff about "v3_targetPos"

namespace Panda.Ibis {
    public class MyIbis : MonoBehaviour
    {
        //check if the destionation of Target2 has identified.
        static bool hasCheckDes;

        GameObject _ibisA;

        [Header(" �� Normal Properties")]
        // properties of the bird
        static public int gender;//1=雌，2=雄  // set when game starts, public is comtem...
        static public int full;// 0饿,1饱
        static public int full_max;
        static public int energy;//0 need to rest, 1 no need 
        static public bool isSingle;
        static public GameObject mate; // make sure it's double sides
        static public int actionPoint;
        static public int maxAP;
        static public int startAP;

        static public bool hasToxic; //中毒与否，若中毒，每回合开始前判定能不能活下去 //no no no, 若是中毒太深就活不下去

        static public bool hasBringTwig;
        static public bool hasBringLiana;

        static public GameObject foodAte;

        static public GameObject currentNest; //for buildNest()

        static public List<GameObject> eggs; // all eggs belongs to this ibis

        static public int APreduced; // due to eating polluted food, max AP would reduced  

        public bool APhasReducedThisTurn;

        static public bool hasCheckApEachNode; // set this bool during the sector which check if succeed of each uncheck AI node



        [Header(" �� Node Structure Mark")]
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

/*        GameObject _targetPos;
        Vector3 v3_targetPos;*/

        listObjOnLand _listObjOnLand;

        LandGen3 _LandGen3;

        CrestedIbis _CrestedIbis;

        Vector2 v2_nearestFood;

        List<GameObject> opSexNPCIbis;

        GameObject choosenIbis; // only for moving to

        int turnsAfterSpawn; // +1 each turn until incubating


        public Animator ani;

        int monthSpawn;

        turnBased _turnBased;

        allCheck _allCheck;

        turnBased __turnBased;

        GameObject _ObjOnLand;


        GameManager _Gamemanager;

        public GameObject _eat;
        public GameObject _goToOpIbis;
        public GameObject _mate;
        public GameObject _buildNest;
        public GameObject _spawn;
        public GameObject _incubate;
        public GameObject _breed;
        public GameObject _rest;

        public GameObject _dot;

        public GameObject _ibisA_FX;

        static public int index_currentEvent; // 当前动作（吃、寻偶、休息等）的发生地点的index

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


            hasCheckDes = false;

            _ibisA = GameObject.Find("ibisA");

            /////////////Properties////////////////////
            ////////////////Properties////////////////////

         //from the start scene, comment it tempera...
            //if (chooseGender.cGender == 1) { gender = 1; }
            //if (chooseGender.cGender == 2) { gender = 2; }
            gender = 1;
            full = 2;// 0��,1��
            full_max = 5;
            energy = 1;//0 need to rest, 1 no need 
            isSingle = true;

            actionPoint = 4;
            maxAP = 6;
            startAP = actionPoint;

            hasToxic = false;

           // mate = GameObject.Find("ibisC");

            hasBringTwig = false;
            hasBringLiana = false;

            eggs = new List<GameObject>();

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

            transform.DOScaleX(0.6f, 0.001f);
            transform.DOScaleY(0.6f, 0.001f);


            isMate = false;
            isCourtship = false;

            _outAI = GameObject.Find("Values").GetComponent<outerAI>();


            foods_l = new List<GameObject>();
            _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();


            v2_foods_l = new List<Vector2>();

            _LandGen3 = GameObject.Find("LandGenerator").GetComponent<LandGen3>();
/*
            _targetPos = GameObject.Find("Target2");
            v3_targetPos = _targetPos.transform.position;*/

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

            _allCheck = GameObject.Find("AllCheck").GetComponent<allCheck>();

            __turnBased = _turnBased.GetComponent<turnBased>();

            _ObjOnLand = GameObject.Find("ObjOnLand");

            // _ibisA_FX =GameObject.Find("ibisA_FX");

            APreduced = 0;
            APhasReducedThisTurn = false;


            _Gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();

            hasCheckApEachNode = false;


        }





        public void breakWhenIbisAAct() //���ڴ�� 
        {
            print("breakWhenIbisAAct()");
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("brambles", false);

            //  GameObject.Find("ibisA").GetComponent<Pathfinding.AILerp>().speed = 0;
            GameObject.Find("ibisA").GetComponent<Nav>().enabled = false;

            GameObject.Find("ibisA").GetComponent<SpriteRenderer>().enabled = false;

            //ibisR on!
            GameObject.Find("ibisR").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("ibisR").transform.localScale = new Vector3(1.8f, 1.8f, 1f);
            GameObject.Find("ibisR").transform.position = GameObject.Find("ibisA").transform.position;
            GameObject.Find("ibisR").GetComponent<Animator>().Play("ibis_break_trap");


            if (GameObject.Find("ibisR").GetComponent<Animator>().GetBool("hasBreakTrap"))
            {
                GameObject.Find("ibisR").GetComponent<Animator>().SetBool("hasBreakTrap", false);

                outOfBreakWhenIbisAAct();
                print("breaking time is over.");
            }
            /*           s
                        print(Time.deltaTime + " and current time:  " + currentTime);
                        if ( Time.deltaTime - currentTime > 2f)
                        {
                            outOfBreakWhenIbisAAct();

                            print("breaking time is over.");
                        }*/

          //  actionPoint = 0;
        }
        public void outOfBreakWhenIbisAAct() //跳出打断
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            //  GameObject.Find("ibisA").GetComponent<Pathfinding.AILerp>().speed = 3;
            GameObject.Find("ibisA").GetComponent<Nav>().enabled = true;

            GameObject.Find("ibisA").GetComponent<SpriteRenderer>().enabled = true;

            GameObject.Find("ibisA").GetComponent<SpriteRenderer>().enabled =true;
            GameObject.Find("ibisR").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("ibisR").GetComponent<Animator>().enabled = false;

            GameObject.Find("ibisR").GetComponent<Animator>().SetBool("hasBreakTrap", false);
        }

        void Update()
        {
            //check if meeting trap over
            //print("AP: " + actionPoint);

            if (GameObject.Find("ibisR").GetComponent<Animator>().GetBool("hasBreakTrap"))
            {
                outOfBreakWhenIbisAAct();
                print("breaking time is over.");
            }



            //check if meeting trap over

            // print("full : " + full);

            /*            if (Input.GetKeyDown(KeyCode.F))
                        {
                            transform.parent.gameObject.GetComponent<Pathfinding.AILerp>().speed = 0;
                            transform.parent.gameObject.GetComponent<SnapToNode>().enabled = false;
                          //  transform.parent.gameObject.GetComponent<SnapToNode>().enabled = true;
                            //�������������Ч��ɶ�����v2���꣬��dotween�ƹ�ȥ
                        }*/
            if (Input.GetKeyDown(KeyCode.F))
            {
                GameObject.Find("ibisA").GetComponent<Pathfinding.AILerp>().speed = 0;
                GameObject.Find("ibisA").GetComponent<SnapToNode>().enabled = false;
                GameObject.Find("ibisA").GetComponent<SpriteRenderer>().enabled = false;

                //ibisR on!
                GameObject.Find("ibisR").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("ibisR").transform.position = GameObject.Find("ibisA").transform.position;
                GameObject.Find("ibisR").GetComponent<Animator>().Play("ibis_break_trap");


                if (GameObject.Find("ibisR").GetComponent<Animator>().GetBool("hasBreakTrap"))
                {
                    GameObject.Find("ibisR").GetComponent<Animator>().SetBool("hasBreakTrap", false);
                    outOfBreakWhenIbisAAct();

                    print("breaking time is over.");
                }
            }


            //old AP caculation
            //actionPoint = 4- GameObject.Find("ibisA").GetComponent<Panda.Ibis.MyIbis>(). landsPassThrough.Count;


            //if (_turnBased.turn == 1)
            //{ actionPoint = 4 - GameObject.Find("ibisA").GetComponent<Panda.Ibis.MyIbis>().landsPassThrough.Count + 1; }
            //// else { actionPoint = landsPassThrough.Count; }


            //print("ap: " + actionPoint);
            //old AP caculation


//            if (actionPoint == 0)
//            {
//                /*                landsPassThrough.Clear();
//                                GetComponent<PandaBehaviour>().enabled = false;

//                                transform.parent.gameObject.GetComponent<Pathfinding.AILerp>().enabled = false;


//                                // gameObject.GetComponent<PandaBehaviour>().enabled = false;

//                                GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<PandaBehaviour>().Reset();
//                                gameObject.GetComponent<PandaBehaviour>().Reset();

//                                _turnBased.newTurnStart();

//                                Destroy(GameObject.Find("TurnBased").transform.GetChild(0).gameObject);*/

//               breakThisTurn();
///*                //========
//                GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<Panda.Ibis.MyTurn>().hasSetPandaActive = false;
//                print("end turn ");
//                quenchAllBeBar();
//                //end this turn 
//                _targetPos.transform.position = v3_targetPos;


//                GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<Panda.Ibis.MyTurn>().hasIbisEnded = true;
//                //===========*/

//                //print("hasIbisEnded: " + GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<Panda.Ibis.MyTurn>().hasIbisEnded);
//                // gameObject.GetComponent<PandaBehaviour>().enabled = false;

//                //?should be destroyed after this turn?
//                // ThisTask.Succeed();
//            }
        }

        public void breakThisTurn()  // break when action point =0
        {
            GameObject.Find("ibisA").GetComponent<Nav>().enabled = false;
            GameObject.Find("ibisA").GetComponent<Animator>().enabled = false;

            int ibisA_currentIndex = aboutGirdIndex.getGirdIndex(GameObject.Find("ibisA_ray"));
           
            //========
            GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<Panda.Ibis.MyTurn>().hasSetPandaActive = false;
            print("end turn ");

            quenchAllBeBar();

            //end this turn 
            //  _targetPos.transform.position = v3_targetPos;

            GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<Panda.Ibis.MyTurn>().hasIbisEnded = true;
            //===========

            print("breakThisTurn() ;");
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

            // v2_allIbils.Add(new Vector2(0f, 0f));// 设ibisA初始在正中央。因代码执行顺序原因第一次运行程序时采不到ibisA坐标
            for (int i = 0; i < _listObjOnLand.NPCibisOnLand.Count; i++)
            {
                if (!v2_allIbils.Contains(_listObjOnLand.NPCibisOnLand[i].GetComponent<objV2Pos>().thisV2))
                { v2_allIbils.Add(_listObjOnLand.NPCibisOnLand[i].GetComponent<objV2Pos>().thisV2); }
            }

/*            foreach (Vector2 v2 in v2_allIbils)
            {
                print(v2);
            }*/

            List<int> index;
            index = new List<int>();
            for (int k = 0; k < v2_allIbils.Count; k++)
            {
                int a = _LandGen3.LandCos.IndexOf(v2_allIbils[k]);
                if (!index.Contains(a))
                { index.Add(a); }
            }

/*            for (int p = 0; p < index.Count; p++)
            {
                _listObjOnLand.isObjOnLand[index[p]] = true;
            }*/

            //  ThisTask.Succeed();
        }

        [Task]
        void enableAILerp()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            transform.parent.gameObject.GetComponent<Pathfinding.AILerp>().enabled = true;

            ThisTask.Succeed();
        }

        [Task]
        void checkHasFood()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            GameObject[] foods2 = GameObject.FindGameObjectsWithTag("food");
            /*            _listObjOnLand.foodOnLand.Clear();
                        _listObjOnLand.foodOnLand_GO.Clear();*/

            for (int i = 0; i < foods2.Length; i++)
            {
                if (!_listObjOnLand.foodOnLand_GO.Contains(foods2[i]))
                { _listObjOnLand.foodOnLand_GO.Add(foods2[i]); }
                if (!_listObjOnLand.foodOnLand.Contains(foods2[i].GetComponent<objV2Pos>().thisV2))
                { _listObjOnLand.foodOnLand.Add(foods2[i].GetComponent<objV2Pos>().thisV2); }
                //  Debug.Log("which food in the scene: " + foods2[i].name);

                if (!GameManager.istance.foodsNav.Contains(foods2[i].GetComponent<Nav>()))
                {
                    int index = Map.instance.transferV2ToIndex(foods2[i].GetComponent<objV2Pos>().thisV2);
                    GameManager.istance.foodsNav[index] = foods2[i].GetComponent<Nav>();
                }
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
            //hasCheckApEachNode = false;

            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("walkingDust", false);

            _listObjOnLand.foodOnLand.Clear();
            _listObjOnLand.foodOnLand_GO.Clear();
            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {
                if (child.gameObject.tag == "food" && !_listObjOnLand.foodOnLand_GO.Contains(child.gameObject))
                {
                    _listObjOnLand.foodOnLand_GO.Add(child.gameObject);

                    if (!_listObjOnLand.foodOnLand.Contains(child.gameObject.GetComponent<objV2Pos>().thisV2))
                    { _listObjOnLand.foodOnLand.Add(child.gameObject.GetComponent<objV2Pos>().thisV2);}
                }
            }
                  
            //seek all food obj in the scene
            v2_foods_l = new List<Vector2>(_listObjOnLand.foodOnLand);


            //Ѱ����ʳ��ĵص㣺ˮ���̲��go!

            v2_nearestFood = getNearestGrid(transform.parent.gameObject.GetComponent<objV2Pos>().thisV2, _listObjOnLand.foodOnLand);

            int index_maxRichFood = -1;
            int maxRichFood = -1;
            bool hasCheckMaxRichFood1 = false;
            bool hasCheckMaxRichFood12 = false;
            List<Nav> RichestFoods;
            RichestFoods = new List<Nav>();

                if (!hasCheckMaxRichFood1)
                {
                    for (int i = 0; i < GameManager.istance.foodsNav.Count; i++)
                    {
                        if (GameManager.istance.foodsNav[i] != null &&
                        GameManager.istance.foodsNav[i].gameObject.GetComponent<objFood>().rich > maxRichFood)
                        {
                            maxRichFood = GameManager.istance.foodsNav[i].gameObject.GetComponent<objFood>().rich;
                            index_maxRichFood = i;
                        }
                    }
                    hasCheckMaxRichFood1 = true;
                }

            if (!hasCheckMaxRichFood12)
            {
                for (int i = 0; i < GameManager.istance.foodsNav.Count; i++)
                {
                    if (GameManager.istance.foodsNav[i] != null &&
                        GameManager.istance.foodsNav[i].gameObject.GetComponent<objFood>().rich == maxRichFood
                        && !RichestFoods.Contains(GameManager.istance.foodsNav[i]))
                    {
                        RichestFoods.Add(GameManager.istance.foodsNav[i]);
                    }
                }
                    hasCheckMaxRichFood12 = true;
            }

            //再在rich最大的食物中随机一个
            int ran = Random.Range(0, RichestFoods.Count-1);
            int index_nearestFood = GameManager.istance.foodsNav.IndexOf(RichestFoods[ran]);


               // Debug.Log("index_nearestFood: " + index_nearestFood); //+ " , " + transform.parent.gameObject.GetComponent<objV2Pos>().thisV2
               //     + " ,  " + v2_foods_l[0]);


/*            
            if (isFirstHalfYear())
                {
                    seekForFoodJantoJun();
                    //Debug.Log("seek food: first half year.");
                }
                if (isLastHalfYear())
                {

                    seekForFoodJuntoNov();
                    // Debug.Log("seek food: last half year.");
                }*/

            //check if ibisA index = nearest food's index, then success

            //int index_nearestFood = Map.instance.transferV2ToIndex(v2_nearestFood);
            int index_ibisA = aboutGirdIndex.getGirdIndex(GameObject.Find("ibisA_ray"));

            index_currentEvent = index_nearestFood; // 以nearest food为准

            seekForFoodJantoJun();

           // print("index_nearestFood: " + index_nearestFood + " , index_ibisA: " + index_ibisA);

            if (index_nearestFood == index_ibisA)
            {
                hasCheckDes = false;

                GameObject.Find("ibisA").GetComponent<Animator>().SetBool("hasWalked", true);

                // add ibisA's v2 to the land grid's list and check
                addIbisOnCurrentLand();

                checkTwoMovingCreatureAtOneGrid();

             //   hasCheckApEachNode = true;

               ThisTask.Succeed();
            }


        }


        void addIbisOnCurrentLand()
        {
            /////// //old path finding version
            /*            Vector2 this_v2;
                        this_v2 = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
                        int inOf;
                        inOf = _LandGen3.LandCos.IndexOf(this_v2);
                        if (!_LandGen3.LandCos_GO[inOf].GetComponent<genPos>().OnThis.Contains(transform.parent.gameObject))
                        {
                            _LandGen3.LandCos_GO[inOf].GetComponent<genPos>().OnThis.Add(transform.parent.gameObject);
                        }

                        // then check 
                        _allCheck.check2NpcOnOneGrid(_LandGen3.LandCos_GO[inOf].GetComponent<genPos>().foodIndex);*/
            /////// //new path finding version
            ///


        }

        void seekForFoodJantoJun()//觅食。水田里有泥鳅、田螺、黄鳝、青蛙以及软体动物。
                                  //河滩中有鱼、虾、螺、蟹及贝类等食物
        {

            //寻找最近的能量最高的上述食物，移过去

            /*            int index_LandCos;
                        index_LandCos = _LandGen3.LandCos.IndexOf(v2_nearestFood);
                        //Debug.Log("index_LandCos: " + index_LandCos);

                            Vector3 food_pos;

                            food_pos = _LandGen3.LandV3s[index_LandCos];
                        //  Debug.Log("food position: " + food_pos);*/


            //int foodIndex = Map.instance.transferV2ToIndex(v2_nearestFood);

           // _ibisA.GetComponent<Nav>().enabled = true;
            GameManager.istance.setSelectNav(_ibisA.GetComponent<Nav>());

            seekLocation(index_currentEvent);
            

            //....
            //如果上面没有，寻找有地点：水田、河滩，go!
            //如果有吃的,吃

            // 以上all true, succeed
        }

        void seekForFoodJuntoNov()///常见于河滩、旱地和塘库边缘（觅食地大而分散）
                                  //觅食。主要以蚯蚓、直翅目昆虫（如蟋蟀、蝼蛄）、螃蟹等为主。
        {
            //地点：河滩、旱地、塘库边缘

            /*            //暂时的：
                        int index_LandCos;
                        index_LandCos = _LandGen3.LandCos.IndexOf(v2_nearestFood);
                        //Debug.Log("index_LandCos: " + index_LandCos);

                        Vector3 food_pos;


                            food_pos = _LandGen3.LandV3s[index_LandCos];
                            //  Debug.Log("food position: " + food_pos);*/

            //int foodIndex = Map.instance.transferV2ToIndex(v2_nearestFood);

           // _ibisA.GetComponent<Nav>().enabled = true;
            GameManager.istance.setSelectNav(_ibisA.GetComponent<Nav>());

            seekLocation(index_currentEvent);

            // seekLocation(food_pos);

        }



        [Task]
        void checkItemsOnLand() // now traps...
                                                //but ibisA cannot seek to a place on which has trap on
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            List<GameObject> items;
            items = new List<GameObject>();

            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {
                if (child.gameObject.name == "trap" )
                { 
                    if (!items.Contains(child.gameObject))
                    items.Add( child.gameObject); 
                }

                // other itmes open
            }

/*            Vector2 v2_ibisA;
            v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
            //Vector2 v2_item;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].GetComponent<objV2Pos>().thisV2 == v2_ibisA)
                {
                    if (items[i].name == "trap")
                    {
                        Debug.Log("meet a trap");

                        // ibisA's properties change: AP points to zero
                        actionPoint = 0;
                        
                    }
                }
            }*/

            ThisTask.Succeed();

        }



        [Task]
        void eat()
        {
            hasCheckApEachNode = false;

            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            int amount_food;
            amount_food = _listObjOnLand.foodOnLand.Count;

         //   print("eat 1");
  //          if (_listObjOnLand.foodOnLand_GO.Count > 0)
   //         {
                //吃
                //Destroy the food & 

                //remove it from the food list
                Vector2 v2_ibis;

                //Vector2 v2_food;
                int index_food =-1;
            GameObject currentFood =null;
            v2_ibis = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
            index_food = _listObjOnLand.foodOnLand.IndexOf(v2_ibis);

            for (int i = 0; i < GameManager.istance.foodsNav.Count; i++)
            {
                if (GameManager.istance.foodsNav[i] && i == index_currentEvent)
                {
                    index_food = i;
                    currentFood = GameManager.istance.foodsNav[i].gameObject;
                }
            }
         //  print("eat 1.2");

            int index2;
            //  index2 = _LandGen3.LandCos.IndexOf(v2_ibis);
            index2 = index_currentEvent;
                _listObjOnLand.isObjOnLand[index2] = false;

         //   print("eat 1.5, index_food: " + index_food );
            //full = full + _listObjOnLand.foodOnLand_GO[index_food].GetComponent<objFood>().rich;
            full = full + currentFood.GetComponent<objFood>().rich;
            if (full > full_max)
                {
                    full = full_max;
                }

         //   print("eat 2");
            //Play pick food animation
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("pickFood");


            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasFood"))
            {
                //foodAte = _listObjOnLand.foodOnLand_GO[index_food];
                foodAte = currentFood;

                //check if polluted
                if (currentFood.GetComponent<objFood>().isToxic)
                    {
                    print("该食物有毒");
                    // ibis' properties change
                    hasToxic = true;

                    if (!APhasReducedThisTurn)
                    {
                        Panda.Ibis.MyIbis.APreduced = Panda.Ibis.MyIbis.APreduced + 1;
                        APhasReducedThisTurn = true;

                        print("Panda.Ibis.MyIbis.APreduced = Panda.Ibis.MyIbis.APreduced + 1;");
                    }

                    print("eat 3");
                }

                Destroy(currentFood);
                _listObjOnLand.foodOnLand_GO.Remove(currentFood);
                _listObjOnLand.foodOnLand.Remove(v2_ibis);

                _listObjOnLand.isObjOnLand[index_food] = false;

                GameManager.istance.foodsNav[index_currentEvent] = null;
                //  print("has food..");

             //   print("eat 4");
              //  if (GameManager.istance.foodsNav[index_currentEvent] == null)//改成hasFood为真
                  if(_ibisA.GetComponent<Animator>().GetBool("hasFood")) 
                {
                    //   print(" < original food amount.");
                    //  set this bool during the sector which check if succeed of each uncheck AI node

                    hasCheckApEachNode = true;

                    lightEat();
                    print("eat 5");
                    ThisTask.Succeed();
                }
            }

        }


        [Task]

        void isFemale()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            if (gender == 1) //��
            { ThisTask.Succeed(); } 
            else { ThisTask.Fail(); }
        
         }

        [Task]
        void isMale()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            if (gender == 2)
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }

        }

        [Task]
        void isThisSingle()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            if (isSingle) 
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }

        [Task]
        void isThereNPCIbis()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);
            bool isAllNull = true;
            foreach (Nav nav in GameManager.istance.NPCsNav)
            {
                if (nav != null) { isAllNull = false; }
            }

           // if (GameManager.istance.NPCsNav.Count > 0)
           if (!isAllNull)
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
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            foreach (Transform child in GameObject.Find("ObjOnLand").transform)
            {
                if (child.gameObject.name == "ibisAdult" && !_listObjOnLand.NPCibisOnLand.Contains(child.gameObject))
                {
                    _listObjOnLand.NPCibisOnLand.Add(child.gameObject);
                }
            }

            int amount;
            amount = 0;
            if (_listObjOnLand.NPCibisOnLand.Count > 0)
            {
                for (int i = 0; i < _listObjOnLand.NPCibisOnLand.Count; i++)
                {
                    if (_listObjOnLand.NPCibisOnLand[i].name == "ibisAdult")
                    {
                        if (_listObjOnLand.NPCibisOnLand[i].GetComponent<NPCIbis>().gender != gender)
                        {
                            //   print(i + " npc: " + _listObjOnLand.NPCibisOnLand[i].GetComponent<NPCIbis>().gender +" , this gender: " + gender);
                            amount = amount + 1;
                        }
                    }
                }
            }

            if (amount > 0) { ThisTask.Succeed(); } else { ThisTask.Fail(); }

        }


        [Task]
        void isThereSingleOpGender()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            int amount;
            amount = 0;
            List<GameObject> allOpGenderOp;
            allOpGenderOp = new List<GameObject>();

            for (int i = 0; i < _listObjOnLand.NPCibisOnLand.Count; i++)
            {
                if (_listObjOnLand.NPCibisOnLand[i].GetComponent<NPCIbis>().gender != gender)
                {
                 //   print("n ibis 0");
                    if (_listObjOnLand.NPCibisOnLand[i].GetComponent<NPCIbis>().isSingle)
                    { amount = amount + 1;
                    //    print("n ibis 1");
                        if (!allOpGenderOp.Contains(_listObjOnLand.NPCibisOnLand[i]))
                        {
                      //      print("n ibis 2");
                            allOpGenderOp.Add(_listObjOnLand.NPCibisOnLand[i]);
                     //       print("n ibis 3");
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
           

            hasCheckApEachNode = false;

            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("walkingDust", false);

            Vector2 c_ibis_v2 = choosenIbis.GetComponent<objV2Pos>().thisV2;
            int c_ibis_index = Map.instance.transferV2ToIndex(c_ibis_v2);


            //_ibisA.GetComponent<Nav>().enabled = true;
            GameManager.istance.setSelectNav(_ibisA.GetComponent<Nav>());

            seekLocation(c_ibis_index);


            Vector2 v2_ibisB;
            Vector2 v2_ibisA;
            v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
            v2_ibisB = choosenIbis.GetComponent<objV2Pos>().thisV2;

            int index_ibisA = aboutGirdIndex.getGirdIndex(GameObject.Find("ibisA_ray"));

           // int index_ibisA = Map.instance.transferV2ToIndex(v2_ibisA);

          //  print("go to Op Gender: index_ibisA： " + index_ibisA + " , c_ibis_index: " + c_ibis_index);
          //  Debug.Log("end: " + choosenIbis.name);

          //  if (v2_ibisA == v2_ibisB)//ibisA reach ibisB
              if (index_ibisA == c_ibis_index)
            {
                Debug.Log("end4.");

                hasCheckDes = false;

                hasCheckApEachNode = true;
                
                // add ibisA's v2 to the land grid's list and check
                addIbisOnCurrentLand();

                checkTwoMovingCreatureAtOneGrid();

                lightGoToOpIbis();

                ThisTask.Succeed();
            }
        }

        [Task]
        void isPartnerOnTheMap()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            if (mate)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void isThisCourtship()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            if (isCourtship)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void Courtship()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            // play ani
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_courtship");

            //Debug.Log("courtship.");
            //after playing the ani, task succeed
            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasCourtship"))
            {
              //  Debug.Log("meet5.");

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
            hasCheckApEachNode = false;

            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("walkingDust", false);

            Vector2 c_mate_v2 = mate.GetComponent<objV2Pos>().thisV2;
            int c_mate_index = Map.instance.transferV2ToIndex(c_mate_v2);

           // _ibisA.GetComponent<Nav>().enabled = true;
            GameManager.istance.setSelectNav(_ibisA.GetComponent<Nav>());

            seekLocation(c_mate_index);

            Vector2 v2_ibisB;
            Vector2 v2_ibisA;
            v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
            v2_ibisB = mate.GetComponent<objV2Pos>().thisV2;

            int ibisA_index = aboutGirdIndex.getGirdIndex(GameObject.Find("ibisA_ray"));

            Debug.Log("going to mate: " + mate.name);

            if (v2_ibisA == v2_ibisB)//ibisA reach ibisB
            {
                Debug.Log("reach to mate.");

                hasCheckDes = false;

                hasCheckApEachNode = true;
                
                // add ibisA's v2 to the land grid's list and check
                addIbisOnCurrentLand();

                checkTwoMovingCreatureAtOneGrid();
                ThisTask.Succeed();
            }
        }

        [Task]
        void Mate()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            // play mate ani (egg)
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_produceEggs");//ani should be changed

            //Succeed
            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasProducedEggs"))
            {
                
                mate.GetComponent<NPCIbis>().isMate = true;
                mate.GetComponent<NPCIbis>().mate = transform.parent.gameObject;

                lightMate();

                //APreduce();
               // actionPoint = actionPoint - 1;

                isMate = true;
                ThisTask.Succeed();
            }

        }




        [Task]
        void comb()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

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
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            //both birds play the ani 
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_touchedBeaks");
                // choosenIbis.GetComponent<Animator>().Play("ibis_touchedBeaks"); // ��Ҫ��λ

                if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasTouchedBeaks"))
                {
                    Debug.Log("touch beaks.");
                    ThisTask.Succeed();
                }

           
        }

        [Task]
        void quarrelWithLoveRival()
        {

            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

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
        void checkMateIbis()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            if (mate)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void checkBuildNest()// to check if there is no nest
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");
            if (nests.Length > 0)
            { ThisTask.Fail(); }
            else { ThisTask.Succeed(); }
        }

            [Task]
        void checkNest()// 需有巢才能进行 -》（反）
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");
            if (nests.Length > 0)
            { ThisTask.Fail(); }
            else { ThisTask.Succeed(); }


        }

        [Task]
        void checkNest_spawn()// // 需有巢无蛋才能进行  -》（反） 
                              //只有两个都true了才能fail
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            bool conA = false;
            bool conB = false;

            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");
            if (nests.Length > 0)
            { conA = true;
                print("nest 0 : " + nests[0]);
            }
            else { conA = false; }


            GameObject[] eggs;
            eggs = GameObject.FindGameObjectsWithTag("egg");
            if (eggs.Length == 0)
            {
                conB = true;
            }
            else { conB = false; }
            print("conA: " + conA + ", conB: " + conB);

            if (conA & conB) //�г��޵�
            {
                ThisTask.Fail();
            }
            else { ThisTask.Succeed(); }
        }

        [Task]
        void checkNest_incubate()// 需要有巢有蛋才能孵化 -》（反）
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            bool conA = false;
            bool conB = false;

            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");
            if (nests.Length > 0)
            { conA = true; }
            else { conA = false; }


            GameObject[] eggs;
            eggs = GameObject.FindGameObjectsWithTag("egg");
            if (eggs.Length > 0)
            {
                conB = true;
            }
            else { conB = false; }

            print("conA: " +conA + ", conB: " +conB);
            if (conA & conB)//�г��е�
            {
                ThisTask.Fail();
            }
            else { ThisTask.Succeed(); }
        }



        [Task]
        void checkHasBuidlingMaterial()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            /*            GameObject[] nests;
                        nests = GameObject.FindGameObjectsWithTag("nest");*/

            if (hasBringLiana || hasBringTwig)
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }

        [Task]
        void checkMaterialOnMap()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            GameObject[] materials;
            materials = GameObject.FindGameObjectsWithTag("material");  

            if (materials.Length > 0)
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }

        [Task]
        void goToMaterial()
        {
            hasCheckApEachNode = false;

            GameObject[] materials;
            materials = GameObject.FindGameObjectsWithTag("material");

            if (materials.Length > 0)
            {
                _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("walkingDust", false);

                int ran;

                    ran = Random.Range(0, materials.Length - 1);

                Vector2 c_materialR_v2 = materials[ran].GetComponent<objV2Pos>().thisV2;
                int c_materialR_index = Map.instance.transferV2ToIndex(c_materialR_v2);
                //index_currentEvent = c_materialR_index;

                //_ibisA.GetComponent<Nav>().enabled = true;
                GameManager.istance.setSelectNav(_ibisA.GetComponent<Nav>());

                seekLocation(c_materialR_index);

                Vector2 v2_material;
                Vector2 v2_ibisA;
                v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
                v2_material = materials[ran].GetComponent<objV2Pos>().thisV2;

                int ibisA_index  = aboutGirdIndex.getGirdIndex(GameObject.Find("ibisA_ray"));

             //   Debug.Log("going to material, ibisA_index: " + ibisA_index + ", c_materialR_index: " + c_materialR_index);

                if (ibisA_index == c_materialR_index)//ibisA reach the nest
                {
                    hasCheckDes = false;

                    hasCheckApEachNode = true;

                    int index_material;
                    // index_material = _LandGen3.LandCos.IndexOf(v2_material);
                    //  _listObjOnLand.isObjOnLand[index_material] = false;
                    GameManager.istance.materialsNav[c_materialR_index] = null;

                    Debug.Log("reach to a material.");

                    // add ibisA's v2 to the land grid's list and check
                    addIbisOnCurrentLand();

                    if (materials[ran].name == "twig") { hasBringTwig = true; }
                    if (materials[ran].name == "liana") { hasBringLiana = true; }

                    Destroy(materials[ran]);

                    checkTwoMovingCreatureAtOneGrid();

                    ThisTask.Succeed();
                }
            }


        }

        [Task]
        void checkIfNestFinished() //有巢就成功
        {
            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");

            GameObject goal_nest = null;

            foreach (GameObject nest in nests)
            {
                if (nest.GetComponent<objNest>()._isFinished)
                {
                    goal_nest = nest;
                }
            }

            if (goal_nest) { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }

        [Task]
        void goToNest(bool hasBuild) // true: finish build; fasle: unfinished
        {
            hasCheckApEachNode = false;

            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("walkingDust", false);

            if (!hasBuild)
            {
                print("goToNest: hasBuild: " + hasBuild);

                currentNest = null;

                // go to the nest. There can only have one nest in the scene.
                // for the last line: need a nest marked as home
                GameObject[] nests;
                nests = GameObject.FindGameObjectsWithTag("nest");

                GameObject goal_nest = null;

                foreach (GameObject nest in nests)
                {
                    if (!nest.GetComponent<objNest>()._isFinished)
                    {
                        goal_nest = nest;
                    }
                }
                //int ran;
                //ran = Random.Range(0, nests.Length - 1);

                //print("nests[ran]: " + nests[ran]);

                if (goal_nest != null)
                {
                    Vector2 c_g_nest_v2 = goal_nest.GetComponent<objV2Pos>().thisV2;
                    int c_g_nest_index = Map.instance.transferV2ToIndex(c_g_nest_v2);

                    //_ibisA.GetComponent<Nav>().enabled = true;
                    GameManager.istance.setSelectNav(_ibisA.GetComponent<Nav>());

                    seekLocation(c_g_nest_index);
                }
                if (goal_nest == null) { print("goal_nest = null."); }

                Vector2 v2_nest;
                //Vector2 v2_ibisA;
               // v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
                v2_nest = goal_nest.GetComponent<objV2Pos>().thisV2;

                int ibisA_index = aboutGirdIndex.getGirdIndex(GameObject.Find("ibisA_ray"));
                int nest_index = Map.instance.transferV2ToIndex(v2_nest);

                Debug.Log("going to nest: " + goal_nest.name);

               // if (v2_ibisA == v2_nest)//ibisA reach the nest
                if (ibisA_index == nest_index)
                {
                    Debug.Log("reach to a nest.");

                    hasCheckDes = false;

                    hasCheckApEachNode = true;

                    // add ibisA's v2 to the land grid's list and check
                    addIbisOnCurrentLand();

                    currentNest = goal_nest;

                    checkTwoMovingCreatureAtOneGrid();

                    ThisTask.Succeed();
                }
            }

            if (hasBuild)
            {
                print("goToNest: hasBuild: " + hasBuild);

                currentNest = null;

                // go to the nest. There can only have one nest in the scene.
                // for the last line: need a nest marked as home
                GameObject[] nests;
                nests = GameObject.FindGameObjectsWithTag("nest");

                GameObject goal_nest = null;

                foreach (GameObject nest in nests)
                {
                    if (nest.GetComponent<objNest>()._isFinished)
                    {
                        goal_nest = nest;
                    }
                }
                //int ran;
                //ran = Random.Range(0, nests.Length - 1);

                //print("nests[ran]: " + nests[ran]);

                    Vector2 c_g_nest_v2 = goal_nest.GetComponent<objV2Pos>().thisV2;
                    int c_g_nest_index = Map.instance.transferV2ToIndex(c_g_nest_v2);

               // _ibisA.GetComponent<Nav>().enabled = true;
                GameManager.istance.setSelectNav(_ibisA.GetComponent<Nav>());

                seekLocation(c_g_nest_index);

                Vector2 v2_nest;
              /*  Vector2 v2_ibisA;*/
              //  v2_ibisA = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
                v2_nest = goal_nest.GetComponent<objV2Pos>().thisV2;

                int ibisA_index = aboutGirdIndex.getGirdIndex(GameObject.Find("ibisA_ray"));
                int nest_index = Map.instance.transferV2ToIndex(v2_nest);

                Debug.Log("going to nest: " + goal_nest.name);

                //if (v2_ibisA == v2_nest)//ibisA reach the nest
                if (ibisA_index == nest_index)
                {
                    Debug.Log("reach to a nest.");

                    hasCheckDes = false;

                    hasCheckApEachNode = true;

                    // add ibisA's v2 to the land grid's list and check
                    addIbisOnCurrentLand();

                    currentNest = goal_nest;

                    checkTwoMovingCreatureAtOneGrid();

                    ThisTask.Succeed();
                }
            }

        }

        [Task]
        void buildNest()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            // play the build ani
            //both birds play the ani 
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_build");
            // choosenIbis.GetComponent<Animator>().Play("ibis_touchedBeaks"); // ��Ҫ��λ

            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasBuild"))
            {

                //change the nest's properties
                 //currentNest.GetComponent<objNest>(). addOneBuildPoint();

                currentNest.GetComponent<objNest>()._isFinished = true;

                //after finishing it , unlock the bool, succeed


                lightBuildNest();
                Debug.Log("build a nest.");
                ThisTask.Succeed();
            }

        }

        [Task]

        void checkNestFinished() // current: _isFinished is Succeed
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);
            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");

            for (int i = 0; i < nests.Length; i++)
            {
                if (nests[i].GetComponent<objNest>()._isFinished)
                {
                    ThisTask.Succeed();
                }
                else { ThisTask.Fail(); }
            }
/*            int ran;
            ran = Random.Range(0, nests.Length - 1);*/


        }

 

        [Task]
        void hasMate()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            if (mate)
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }

        [Task]

        void spawn()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            int ran_amounts_egg;
            ran_amounts_egg = -1;

            List<int> ran;
            ran = new List<int>();
            ran.Add(1); ran.Add(2); ran.Add(3); ran.Add(4);
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
                    egg.transform.SetParent(null);

                    egg.GetComponent<Rigidbody>().isKinematic = true;
                    egg.GetComponent<SnapToNode>().enabled = false;

                    if (!eggs.Contains(egg))
                    {
                        eggs.Add(egg);
                    }

                    //set egg's position 
                    //foreach (Transform child in GameObject.Find("ObjOnLand").transform)
                    //{
                    //    if (child.gameObject.name == "nest"
                    //        && child.gameObject.GetComponent<objV2Pos>().thisV2 == GameObject.Find("ibisA").GetComponent<objV2Pos>().thisV2)
                    //    {
                    //        egg.transform.position = child.gameObject.transform.position;
                    //    }
                    //}

                    //for (int i = 0; i < eggs.Count; i++)
                    //{
                    //    float egg_x = eggs[i].transform.position.x;
                    //    float egg_y = eggs[i].transform.position.y;
                    //    float egg_z = eggs[i].transform.position.z;

                    //    if (i == 0)
                    //    { eggs[0].transform.position = new Vector3(egg_x + 0.45f, egg_y + 0.633f, egg_z); }
                    //    if (i == 1)
                    //    { eggs[1].transform.position = new Vector3(egg_x + 0.646f, egg_y + 0.552f, egg_z); }
                    //    if (i == 2)
                    //    { eggs[2].transform.position = new Vector3(egg_x + 0.138f, egg_y + 0.639f, egg_z); }
                    //    if (i == 3)
                    //    { eggs[3].transform.position = new Vector3(egg_x + 0.355f, egg_y + 0.42f, egg_z); }
                    //}

                    //egg.transform.SetParent(GameObject.Find("ObjOnLand").transform);

                    if (k == ran_amounts_egg - 1)
                    {
                        isSpawn = true;

                        lightSpawn(ran_amounts_egg);
                        print("spawn ");
                       // monthSpawn = _outAI.month;
                        ThisTask.Succeed();
                    }
                }

            }
        }



        [Task]
        void checkCanIncubate()
        {                                    //添加CHECK并且巢内有蛋

            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            GameObject[] eggs;
            eggs = GameObject.FindGameObjectsWithTag("egg");
            if (eggs.Length == 0)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
            
            //if (eggs) //因为蛋只能在窝里
        }

        [Task]
        void incubate() //once it's an egg...
                        //和npc配偶轮流执行，自己不在，npc配偶会一只在，回巢后npc配偶会出巢
        {

            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_incubate");
                // egg's properties change. (And eggs are their own "branches")

                //    }
                // finished the ani, succeed
                if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasIncubated"))
                {
                //the properties of egg changes

                    foreach (GameObject egg in eggs) // ���е��������������
                    {
                        egg.GetComponent<objEgg>().hatchCurrentTurn = egg.GetComponent<objEgg>().hatchCurrentTurn + 1;
                    }

                    lightIncubate();
                    print(" incubate.");
                    ThisTask.Succeed();
                }
        }


        [Task]
        void checkBirdling() // need to add checking birdling stuff
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            GameObject[] birdlings;
            birdlings = GameObject.FindGameObjectsWithTag("birdling");
            if (birdlings.Length == 0)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }



        [Task]
        void pickFood()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            int amount_food =0;
           // amount_food = _listObjOnLand.foodOnLand.Count;

            bool hasCount = false;
            if (!hasCount)
            {
                for (int i = 0; i < GameManager.istance.foodsNav.Count; i++)
                {
                    if (GameManager.istance.foodsNav[i] != null)
                    {
                        amount_food = amount_food + 1;
                    }
                }
                hasCount = true;
            }
            print("pickFood() , amount_food= " + amount_food);

            //          if (_listObjOnLand.foodOnLand_GO.Count > 0)
            //         {
            //吃
            //Destroy the food & 

            //remove it from the food list
            Vector2 v2_ibis;
            //Vector2 v2_food;
            int index_food;
            v2_ibis = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;
            //index_food = _listObjOnLand.foodOnLand.IndexOf(v2_ibis);
            index_food = Map.instance.transferV2ToIndex(v2_ibis);

            int index2;
            index2 = _LandGen3.LandCos.IndexOf(v2_ibis);
            _listObjOnLand.isObjOnLand[index2] = false;

            //Play pick food animation
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("pickFood");


            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasFood"))
            {
                // Destroy(_listObjOnLand.foodOnLand_GO[index_food]); // old version
                Destroy(GameManager.istance.foodsNav[index_food].gameObject);

                _listObjOnLand.foodOnLand_GO.Remove(_listObjOnLand.foodOnLand_GO[index_food]);
                _listObjOnLand.foodOnLand.Remove(v2_ibis);

                GameManager.istance.foodsNav[index_food] = null;

                _listObjOnLand.isObjOnLand[index_food] = false;
                // need remove from all allitemList?

              //  print("has food..");

                if (GameManager.istance.foodsNav[index_food] == null )
                {
                   // print(" < original food amount.");

                    ThisTask.Succeed();
                }
            }
        }



        [Task]
        void breed()///feed the baby bird
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            // play the ani
            transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_feedBaby");

            // baby birds' properties change

            //finished the ani, unlock bool, succeed
            if (transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.GetBool("hasFeedBaby"))
            {
                //the birdling's properties change

                lightBreed();
                ThisTask.Succeed();
            }
        }



        [Task]
        void rest()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("zzzz", false);

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
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("idk", true);

            if (GameObject.Find("ibis_begin"))
            {
                GameObject.Find("ibis_begin").GetComponent<MyIbis_begin>().enabled = false;
                GameObject.Find("ibis_begin").SetActive(false);
            }

            hasCheckDes = false;

            transform.parent.gameObject.GetComponent<Pathfinding.AILerp>().enabled = false;
            //transform.parent.gameObject.GetComponent<Animator>().enabled = false;

            GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<Panda.Ibis.MyTurn>().hasSetPandaActive = false;
            print("end turn  ");
            quenchAllBeBar();
            //end this turn 
            //_targetPos.transform.position = v3_targetPos;


            GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<Panda.Ibis.MyTurn>().hasIbisEnded = true;
            //print("hasIbisEnded: " + GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<Panda.Ibis.MyTurn>().hasIbisEnded);
            // gameObject.GetComponent<PandaBehaviour>().enabled = false;
            
            //?should be destroyed after this turn?
            ThisTask.Succeed();
        }









        [Task]
        void Next()
        {
            _ibisA_FX.GetComponent<ibisA_2D_Fx>().awakeASF("walkingDust", true);

            print("next - " + gameObject.name );

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

        void seekLocation(int _index)
        {
            if (!hasCheckDes)
            {
                //_targetPos.transform.DOMove(destination, 0.000001f, false);
                hasCheckDes = true;

                // go 
                transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_walk");
                //_CrestedIbis.ibisMove1();

                //play FX
                //_ibisA_FX.SetActive

                //bool isActive = _ibisA_FX.activeSelf;
                //_ibisA_FX.SetActive(!isActive);

                //print("play fx.");

                GameObject.Find("ibisA").GetComponent<Nav>().enabled = true;
                GameObject.Find("ibisA").GetComponent<Nav>().stepLength = 0;

                _Gamemanager.setMovingGoal(_index);

            }

                //              Debug.Log("move to destination: " + destination);


        }





            /////////////EEEEEEEE////////////Basic Element  Action Pools/////////////////////////
            ///       /////////////////////////Basic Element  Action Pools/////////////////////////








            /////////////SSSSSSSSS////////////Gears/////////////////////////
            ///       /////////////////////////Gears/////////////////////////
            ///

            void checkTwoMovingCreatureAtOneGrid()
        {
            foreach (Transform child in _ObjOnLand.transform)
            {
                if (child.gameObject.name =="ibisAdult" && !_listObjOnLand.allIbisAdults.Contains(child.gameObject))
                {
                    _listObjOnLand.allIbisAdults.Add(child.gameObject);
                }
                if (child.gameObject.name == "egret" && !_listObjOnLand.allEgrets.Contains(child.gameObject))
                {
                    _listObjOnLand.allEgrets.Add(child.gameObject);
                }
            }

            //compare all ibisA, ibisAdults, egret
            Vector2 v2_ibisA = GameObject.Find("ibisA").GetComponent<objV2Pos>().thisV2;

            
            for (int i = 0; i < _listObjOnLand.allIbisAdults.Count; i++)
            {
                if (v2_ibisA == _listObjOnLand.allIbisAdults[i].GetComponent<objV2Pos>().thisV2)
                {
                    print("ibisA meets an adult ibis.");
                    twoMove(GameObject.Find("ibisA"), _listObjOnLand.allIbisAdults[i]) ;
                    //two move.
                }
            }
            for (int i = 0; i < _listObjOnLand.allEgrets.Count; i++)
            {
                if (v2_ibisA == _listObjOnLand.allEgrets[i].GetComponent<objV2Pos>().thisV2)
                {
                    print("ibisA meets an egret.");
                    twoMove(GameObject.Find("ibisA"), _listObjOnLand.allEgrets[i]);
                    //two move.
                }
            }
            for (int i = 0; i < _listObjOnLand.allEgrets.Count; i++)
            {
                for (int k = 0; k < _listObjOnLand.allIbisAdults.Count; k++)
                {
                    if (_listObjOnLand.allIbisAdults[i].GetComponent<objV2Pos>().thisV2
                        == _listObjOnLand.allEgrets[k].GetComponent<objV2Pos>().thisV2)
                    {
                        print("an ibis adult meets an egret.");
                        twoMove(_listObjOnLand.allIbisAdults[i], _listObjOnLand.allEgrets[k]);
                        //two move.
                    }
                }
            }
        }

        void twoMove(GameObject gojA, GameObject gojB)//  同一格子时，两只都让一让
        {
            gojA.GetComponent<SnapToNode>().enabled = false;
            gojB.GetComponent<SnapToNode>().enabled = false;

            float endX = gojA.transform.position.x -0.613f;
            float endY = gojA.transform.position.y + 0.195f;

            float B_endX = gojB.transform.position.x + 0.64f;
            float B_endY = gojA.transform.position.y - 0.21f;

            gojA.transform.DOMove(new Vector3(endX, endY, gojA.transform.position.z), 0.5f);
            gojB.transform.DOMove(new Vector3(B_endX, B_endY, gojB.transform.position.z), 0.5f);

        }

        void breakWhenMoving()//用这个打断，然后去做一些事情，原理是move the Target
                              //但是恢复打断时，要将target放回原来的地方去
                              //
        {
            Vector3 v3_current;
            v3_current = transform.parent.gameObject.GetComponent<objV2Pos>().thisV2;

            //_targetPos.transform.DOMove(v3_current,0.001f,false);
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

            //Ȼ����xs ��ys�����е������Ҿ���ֵ����
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
           // Debug.Log("set has picked food true.");
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

        /*        public void setHasBreakTrap()
                {
                    GetComponent<Panda.Ibis.MyIbis>().ani.SetBool("hasBreakTrap", true);
                }*/


        string monthEnToCh(int month)
        {
            string _month;
            _month = "没有月份中文值";
            if (month == 6) { _month = "六月"; }
            if (month == 7) { _month = "七月"; }
            if (month == 8) { _month = "八月"; }
            if (month == 9) { _month = "九月"; }
            if (month == 10) { _month = "十月"; }
            if (month == 11) { _month = "十一月"; }
            if (month == 12) { _month = "十二月"; }
            if (month == 1) { _month = "一月"; }
            if (month == 2) { _month = "二月"; }
            if (month == 3) { _month = "三月"; }
            if (month == 4) { _month = "四月"; }
            if (month == 5) { _month = "五月"; }

            return _month ;
        }
        string foodEnToCh(string food)
        {
            string _food;
            _food = "没有食物中文值";
            if (food == "loach") { _food = "泥鳅"; }
            if (food == "crucian") { _food = "鲫鱼"; }
            if (food == "frog") { _food = "青蛙"; }
            if (food == "shrimp") { _food = "小虾"; }
            if (food == "crab") { _food = "小蟹"; }
            if (food == "spiralShell") { _food = "螺"; }
            if (food == "shellFish") { _food = "甲壳类"; }
            if (food == "snail") { _food = "蜗牛"; }
            if (food == "cricket") { _food = "蟋蟀"; }
            if (food == "earthWorm") { _food = "蚯蚓"; }
            if (food == "rice") { _food = "稻米"; }
            if (food == "bean") { _food = "豆类"; }
            if (food == "treeSeed") { _food = "树种子"; }

            return _food;
        }

        void APreduce()  // the problem is... has this method run only for once?
        {
           // actionPoint = actionPoint - 1;  
        }


        //////Start///////Set BeBar/////////////////////
        //////Start///////Set BeBar/////////////////////
        void lightEat()
        {
            _eat.SetActive(true);
            //_dot.transform.DOLocalMoveX(-347f, 1f);

            _dot.transform.DOLocalMoveX(_eat.GetComponent<RectTransform>().anchoredPosition.x, 1f);

            string thisPlot;
/*            thisPlot = " Ibis eats a " + foodAte.name
                + " at " + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
                + " in " + _outAI.month;*/

            thisPlot = monthEnToCh( _outAI.month)+ " 朱鹮吃了一个 " + foodEnToCh( foodAte.name)
                + " 在 " + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand +"." ;

            _turnBased.GetComponent<story>().addTurnStory(__turnBased.turn, thisPlot);
            _turnBased.GetComponent<story>().showPlotsThisTurn(thisPlot);

            APreduce();

            Debug.Log(thisPlot);
        }

        void lightGoToOpIbis()
        {
            _goToOpIbis.SetActive(true);
            _dot.transform.DOLocalMoveX(_goToOpIbis.GetComponent<RectTransform>().anchoredPosition.x, 1f);

            string thisPlot;
/*            thisPlot = "Ibis meets " + mate + " then they become a couple in " + _outAI.month
                 + " at " + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
                 + ".";*/

                thisPlot = "朱鹮碰见了" + mate +"在"+ monthEnToCh(_outAI.month) + " , 随后它们成为了一对儿 " 
             + "在" + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
             + ".";

            _turnBased.GetComponent<story>().addTurnStory(__turnBased.turn, thisPlot);
            _turnBased.GetComponent<story>().showPlotsThisTurn(thisPlot);

            APreduce();

            Debug.Log(thisPlot);
        }

        void lightMate()
        {
           // print("lightMate.");

            _mate.SetActive(true);
            _dot.transform.DOLocalMoveX(_mate.GetComponent<RectTransform>().anchoredPosition.x, 1f);

            string thisPlot;
/*            thisPlot = "This couple of ibis decide to form a form a family in " + _outAI.month
                 + " at " + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
                 + ".";*/

                    thisPlot = "这对情侣决定在" + monthEnToCh(_outAI.month) +"组成一个小家庭"
             + "在" + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
             + ".";

            _turnBased.GetComponent<story>().addTurnStory(__turnBased.turn, thisPlot);
            _turnBased.GetComponent<story>().showPlotsThisTurn(thisPlot);

            APreduce();

            Debug.Log(thisPlot);
        }

        void lightBuildNest()
        {
            _buildNest.SetActive(true);
            _dot.transform.DOLocalMoveX(_buildNest.GetComponent<RectTransform>().anchoredPosition.x, 1f);

            string thisPlot;
/*            thisPlot = "Ibis builds a nest in " + _outAI.month
                             + " at " + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
                             + ".";*/
            thisPlot = "在"+monthEnToCh(_outAI.month)+ "朱鹮建了一个新巢" 
                 + "在" + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
                 + ".";

            _turnBased.GetComponent<story>().addTurnStory(__turnBased.turn, thisPlot);
            _turnBased.GetComponent<story>().showPlotsThisTurn(thisPlot);

            APreduce();

            Debug.Log(thisPlot);
        }

        void lightSpawn(int am_egg)
        {
            _spawn.SetActive(true);
            _dot.transform.DOLocalMoveX(_spawn.GetComponent<RectTransform>().anchoredPosition.x, 1f);

            string thisPlot;
/*            thisPlot = "Ibis spawns " + am_egg + " eggs " + _outAI.month
                             + " at " + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
                             + ".";*/
            thisPlot = "朱鹮孵化了" + am_egg + "个蛋在" + monthEnToCh(_outAI.month)
                 + "在" + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
                 + ".";

            _turnBased.GetComponent<story>().addTurnStory(__turnBased.turn, thisPlot);
            _turnBased.GetComponent<story>().showPlotsThisTurn(thisPlot);

            APreduce();

            Debug.Log(thisPlot);
        }

        void lightIncubate()
        {
            _incubate.SetActive(true);
            _dot.transform.DOLocalMoveX(_incubate.GetComponent<RectTransform>().anchoredPosition.x, 1f);

            string thisPlot;
            thisPlot = "Ibis incubates " + _outAI.month
                 + " at " + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
                 + ".";
            _turnBased.GetComponent<story>().addTurnStory(__turnBased.turn, thisPlot);
            _turnBased.GetComponent<story>().showPlotsThisTurn(thisPlot);

            APreduce();

            Debug.Log(thisPlot);
        }

        void lightBreed()
        {
            _breed.SetActive(true);
            _dot.transform.DOLocalMoveX(_breed.GetComponent<RectTransform>().anchoredPosition.x, 1f);

            string thisPlot;
            thisPlot = "Ibis feeds its birdlings" + _outAI.month
                         + " at " + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
                         + ".";
            _turnBased.GetComponent<story>().addTurnStory(__turnBased.turn, thisPlot);
            _turnBased.GetComponent<story>().showPlotsThisTurn(thisPlot);

            APreduce();

            Debug.Log(thisPlot);
        }

        void lightRest()
        {
            _rest.SetActive(true);
            _dot.transform.DOLocalMoveX(_rest.GetComponent<RectTransform>().anchoredPosition.x, 1f);

            string thisPlot;
/*            thisPlot = "Ibis goes to sleep in " + _outAI.month
             + " at " + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
             + ".";*/
                        thisPlot = monthEnToCh( _outAI.month) + "朱鹮去睡觉了 " 
             + "在" + transform.parent.gameObject.GetComponent<objV2Pos>().thisLand
             + ".";
            _turnBased.GetComponent<story>().addTurnStory(__turnBased.turn, thisPlot);
            _turnBased.GetComponent<story>().showPlotsThisTurn(thisPlot);

            APreduce();

            Debug.Log(thisPlot);
        }

        void quenchAllBeBar()
        {
            if (_eat)
            _eat.SetActive(false );
            if (_goToOpIbis)
            _goToOpIbis.SetActive(false);
            _mate.SetActive(false);
            if(_buildNest)
            _buildNest.SetActive(false);
            if(_spawn)
            _spawn.SetActive(false);
            if(_incubate)
            _incubate.SetActive(false);
            if(_rest)
            _rest.SetActive(false);
            if(_breed)
            _breed.SetActive(false);

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
/*            //if (bool ����)
            // go 
            string _test;
            _test = test;

            Debug.Log(_test);

            if (_test == "yes")
            { ThisTask.Succeed(); }*/

            ////////////////
              //_targetPos.transform.DOMove(destination, 0.000001f, false);
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




    }
}


