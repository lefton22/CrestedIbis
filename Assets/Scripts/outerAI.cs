using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using DG.Tweening;

public class outerAI : MonoBehaviour
{
    //All outside environemnt
    //Cards dealing

    //all processing through the seasons

    public int month;
    public int temperature;// 1= low, 2= mid, 3 = warm
    public int elevation; // switch the map through a game?? or adjust the hex's height?
                          // 1�����ͺ��Σ�2�����ߺ�

   // List<int> weight;
    public List<int> cardsWeight;  // 7 slots.
                                   //1=rich food , 2= ave food ,3= poor food,,,,
                                   // 6= neutrual NPC, 7 = mal NPC, 8 = good NPC
                                   //11 = nest
                                   //16 = human-made building
                                   //21 = building material

    public int pollutionRate; // if higher, then... the baseline is 5
    public int MaxPollution; // can be modified during game starting

    GameObject _t_month;
    GameObject _t_temperature;
    GameObject _turnBased;
    GameObject _t_turn;

    GameObject _t_gender;
    GameObject _t_full;
    GameObject _t_energy;
    GameObject _t_isSingle;
    GameObject _t_mate;
    GameObject _t_actionPoint;

    GameObject _ibisA;

    GameObject _ISframe;
    GameObject _ISeyeOpen;
    GameObject _ISeyeSleepy;
    GameObject _ISlineNoMate;
    GameObject _ISlineHasMate;
    GameObject _ISgizzard;
    GameObject _ISmateProfile;
    GameObject _ISHeart;
    GameObject _ISgender;

    Sprite sp_female;
    Sprite sp_male;
    Sprite sp_gizzard;
    Sprite sp_openEye;
    Sprite sp_sleepyEye;

    public GameObject _monthNum;
    public GameObject _monthFrame;

    public List<float> monthXs;
/*    public GameObject _1p;
    public GameObject _2p;
    public GameObject _3p;
    public GameObject _4p;
    public GameObject _5p;
    public GameObject _6p;
    public GameObject _7p;
    public GameObject _8p;
    public GameObject _9p;
    public GameObject _10p;
    public GameObject _11p;
    public GameObject _12p;*/

    void Start()
    {
       
        // month = 7;//暂定7月开始
        // month = 1;//暂定 test
        temperature = 0;

        _t_month = GameObject.Find("t_month");
        _t_temperature = GameObject.Find("t_temperature");
        _t_turn = GameObject.Find("t_turn");
        _turnBased = GameObject.Find("TurnBased");

        _t_gender = GameObject.Find("t_gender");
        _t_full = GameObject.Find("t_full");
        _t_energy = GameObject.Find("t_energy");
        _t_isSingle = GameObject.Find("t_isSingle");
        _t_mate = GameObject.Find("t_mate");
        _t_actionPoint = GameObject.Find("t_actionPoint");

        _ibisA = GameObject.Find("ibisA");

        _ISframe = GameObject.Find("");
        _ISeyeOpen = GameObject.Find("ISeyeOpen");
        _ISeyeSleepy = GameObject.Find("ISeyeSleepy");
        _ISlineNoMate = GameObject.Find("ISlineNoMate");
        _ISlineHasMate = GameObject.Find("ISlineHasMate");
        _ISgizzard = GameObject.Find("ISgizzard");
        _ISmateProfile = GameObject.Find("ISmateProfile");
        _ISHeart = GameObject.Find("ISHeart");
        _ISgender = GameObject.Find("ISgender");

        sp_female = Resources.Load<Sprite>("ui/formal/female");
        sp_male = Resources.Load<Sprite>("ui/formal/male");
        sp_gizzard = Resources.Load<Sprite>("ui/formal/gizzard-stuff");
        sp_openEye = Resources.Load<Sprite>("ui/formal/eye-open");

        sp_sleepyEye = Resources.Load<Sprite>("ui/formal/eye-sleepy");

       // _monthNum = GameObject.Find("monthNum");


        ////////GameObject needed
        ///鹭
        ///朱鹮NPC
        ///草籽
        ///nest ：繁殖率
        ///幼鸟朱鹮：成长度，生长否
        ///
        /////////
        ///


        // weight = new List<int>();
        //weight.InsertRange(weight.Count, new int[] { 1, 2, 3, 6, 7, 11, 16, 21 });

        //cardsWeight = new List<int>();
        //foods
        //npcs
        //nest
        //...?

        pollutionRate = Random.Range(0, MaxPollution);



        float x;
        x = _monthFrame.GetComponent<monthsPos>().monthXs[6];
        _monthFrame.transform.DOLocalMoveX(x, 1f);

/*        monthXs.Add(_1p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_2p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_3p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_4p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_5p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_6p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_7p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_8p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_9p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_10p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_11p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_12p.GetComponent<RectTransform>().anchoredPosition.x);*/
    }

    void Update()
    {
      // _t_month.GetComponent<TMPro.TextMeshProUGUI>().text = "Month : " + month;
      //  _t_temperature.GetComponent<TMPro.TextMeshProUGUI>().text = "C : " + temperature;
        _t_turn.GetComponent<TMPro.TextMeshProUGUI>() .text =_turnBased.GetComponent<turnBased>().turn.ToString();

        //print("Gender: " + Panda.Ibis.MyIbis.gender
        //
       // print("panda ap: " + Panda.Ibis.MyIbis.actionPoint);
        _t_actionPoint.GetComponent<TMPro.TextMeshProUGUI>().text = /* "AP: " + */Panda.Ibis.MyIbis.actionPoint.ToString();

        if (Panda.Ibis.MyIbis.gender ==1)
        {
            //_t_gender.GetComponent<TMPro.TextMeshProUGUI>().text = "雌"; 
            _ISgender.GetComponent<Image>().sprite = sp_female;
        }
        if (Panda.Ibis.MyIbis.gender == 2)
        {
            // _t_gender.GetComponent<TMPro.TextMeshProUGUI>().text = "雄"; 
            _ISgender.GetComponent<Image>().sprite = sp_male;
        }

        if (Panda.Ibis.MyIbis.full == 0)
        {
            //_t_full.GetComponent<TMPro.TextMeshProUGUI>().text = "饿 ";
            _ISgizzard.GetComponent<Image>().enabled = false;
           
        }
        if (Panda.Ibis.MyIbis.full == 1)
        {
            //_t_full.GetComponent<TMPro.TextMeshProUGUI>().text = "饱 ";
            _ISgizzard.GetComponent<Image>().enabled = true;
            _ISgizzard.GetComponent<Image>().sprite = sp_gizzard;
        }

        if (Panda.Ibis.MyIbis.energy == 0)
        {
            //_t_energy.GetComponent<TMPro.TextMeshProUGUI>().text = "需要休息 ";
            _ISeyeOpen.GetComponent<Image>().enabled = false;
            _ISeyeSleepy.GetComponent<Image>().enabled = true;
        }
        if (Panda.Ibis.MyIbis.energy == 1)
        {
            //_t_energy.GetComponent<TMPro.TextMeshProUGUI>().text = "不需要休息";
            _ISeyeOpen.GetComponent<Image>().enabled = true;
            _ISeyeSleepy.GetComponent<Image>().enabled = false;
        }
        if (Panda.Ibis.MyIbis.isSingle)
        {
            //_t_isSingle.GetComponent<TMPro.TextMeshProUGUI>().text = "形单影只";
            _ISlineNoMate.GetComponent<Image>().enabled = true;
            _ISlineHasMate.GetComponent<Image>().enabled = false;
        }
        if (!Panda.Ibis.MyIbis.isSingle)
        {
            // _t_isSingle.GetComponent<TMPro.TextMeshProUGUI>().text = "有家室";
            _ISlineNoMate.GetComponent<Image>().enabled = false;
            _ISlineHasMate.GetComponent<Image>().enabled = true;
        }

        if (Panda.Ibis.MyIbis.mate != null)
        {
            // _t_mate.GetComponent<TMPro.TextMeshProUGUI>().text = "Mate: " + Panda.Ibis.MyIbis.mate.name; 
            _ISHeart.GetComponent<Image>().enabled = true;
        }
        if (Panda.Ibis.MyIbis.mate == null)
        {
            //_t_mate.GetComponent<TMPro.TextMeshProUGUI>().text = "Mate: none"; 
            _ISHeart.GetComponent<Image>().enabled = false;
        }

       
    }

    public void changeMonthIcon(int _month)
    {
        Sprite sp_monthNum;
        //print("ui/formal/" + _month.ToString() + "y");
        sp_monthNum = Resources.Load<Sprite>("ui/formal/" + _month.ToString() + "y") ;
        _monthNum.GetComponent<Image>().sprite = sp_monthNum;
       // print(_monthNum);

        setMonthIconPos(_month);
    }
    void setMonthIconPos(int _month)
    {
       // float x;
        /*        foreach (float f in monthXs)
                {
                    print("_month: " + f);
                } 
                print("_month: " *//*+ monthXs[1] *//*);*/

        // print("_month: " + _monthFrame.GetComponent<monthsPos>().monthXs[_month - 1]);

        /*         x =monthXs[_month];
                _monthFrame.transform.DOLocalMoveX(x, 1f);*/

        // _monthFrame.transform.DOLocalMoveX(1, 1f);
        moveMonth(_month);
    }

    void moveMonth(int __month)
    {
        if (__month == 1) { _monthFrame.transform.DOLocalMoveX(23.8f, 1f); }
        if (__month == 2) { _monthFrame.transform.DOLocalMoveX(107.2f, 1f); }
        if (__month == 3) { _monthFrame.transform.DOLocalMoveX(191f, 1f); }
        if (__month == 4) { _monthFrame.transform.DOLocalMoveX(283f, 1f); }
        if (__month == 5) { _monthFrame.transform.DOLocalMoveX(372f, 1f); }
        if (__month == 6) { _monthFrame.transform.DOLocalMoveX(448f, 1f); }
        if (__month == 7) { _monthFrame.transform.DOLocalMoveX(-446.3f, 1f); }
        if (__month == 8) { _monthFrame.transform.DOLocalMoveX(-370.2f, 1f); }
        if (__month == 9) { _monthFrame.transform.DOLocalMoveX(-291.1f, 1f); }
        if (__month == 10) { _monthFrame.transform.DOLocalMoveX(-214.2f, 1f); }
        if (__month == 11) { _monthFrame.transform.DOLocalMoveX(-134.4f, 1f); }
        if (__month == 12) { _monthFrame.transform.DOLocalMoveX(-55.1f, 1f); }
    }

        void ibisTranColor() //换毛色
    {
        if (month == 6 || month == 7 || month == 8 || month == 9)
        {
            Debug.Log("ibis' feather is white");

        }
        if (month == 12 || month == 1 || month == 2)
        {
            Debug.Log("ibis' featehr is grey.");

        }
    }

    public void checkCardsWeight()
    {
        foreach (int c in cardsWeight)
        { print("card weight: " + c); }
    }

    public void Jul1() // turn 1 //suppose that July is the start of the game 繁殖季节在6月结束
    {
        //All outside environemnt

        //Cards dealing (weight)
               // cardsWeight.Clear();
                //cardsWeight.InsertRange(weight.Count, new int[] {1,1,6,1,2,21,21});
                 cardsWeight.AddMany(1, 1, 6, 1, 2, 21, 21);
                //  cardsWeight = new List<int> { 1, 1, 6, 1, 2, 21, 21 };
               //cardsWeight.Add(1); cardsWeight.Add(1); cardsWeight.Add(6);
/*                foreach (int c in cardsWeight)
                { print("card weight: " + c); }*/

    }
    public void Jul2() // turn 2 
    {
        //All outside environemnt

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 2, 6, 1, 2, 21, 11 });
    }

    public void Aug1() // turn 3
    {
        //All outside environemnt

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 1, 6, 2, 6, 21, 11 });
    }

    public void Aug2() // turn 4
    {
        //All outside environemnt

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 2, 6, 7, 6, 11, 11 });
    }

    public void Sept1()
    {
        //All outside environemnt

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 2, 6, 7, 1, 11, 11 });
    }
    public void Sept2()
    {
        //All outside environemnt

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 2, 6, 7, 3, 11, 11 });
    }

    public void Oct1()
    {
        //All outside environemnt

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 2, 2, 6, 7, 1, 21, 21});
    }

    public void Oct2()
    {
        //All outside environemnt

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 3, 6, 7, 1, 11, 11 });
    }

    public void Nov1()
    {
        //All outside environemnt
        temperature = 1;

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 1, 1, 7, 1, 11, 11 });
    }

    public void Nov2()
    {
        //All outside environemnt
        temperature = 1;

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 1, 6, 2, 1, 21, 11 });
    }

    public void Dec1()
    {
        //All outside environemnt
        temperature = 1;

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 1, 6, 2, 1, 21, 11 });
    }

    public void Dec2()
    { //All outside environemnt
        temperature = 1;

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 1, 6, 2, 1, 21, 11 });
    }

    public void Jan1()
    { //All outside environemnt
        temperature = 1;

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 1, 6, 2, 1, 21, 11 });
    }
    public void Jan2()
    { //All outside environemnt
        temperature = 1;

        //Cards dealing (weight)
        cardsWeight.Clear();
        cardsWeight.InsertRange(cardsWeight.Count, new int[] { 1, 1, 6, 2, 1, 21, 11 });
    }

    public void Feb1()
    { }
    public void Feb2()
    { }

    public void Mar1()
    { }
    public void Mar2()
    { }
    public void Apr1()
    { }
    public void Apr2()
    { }

    public void May1()
    { }

    public void May2()
    { }

    public void Jun1()
    { }

    public void Jun2()
    { }

    /*    void winter()
        {
            if (month ==11 || month ==12|| month == 1)
            {
                Debug.Log("气温变低，非繁殖期，集群生活，鹭会出现");

                //很多朱鹮出现
                //鹭会出现
                TemperatureChange(5);
                otherIbisShowUp();
                heronShowUp();


            }
        }

        void seekForFood()
        {
            grassSeedShowUp();
            Debug.Log("草籽、植物纤维零星出现在其它地方");


            if (month == 11 || month == 12 || month == 1)
            {
                Debug.Log("河流、稻田里的食物减少");
            }
        }*/


    ///more seperate
    ///    ///more seperate
    ///more seperate

    ///////Environment
    int TemperatureChange(int change)
    {
        int temp;
        temp =  change;
        return temp;
    }


    //////NPC
    void heronShowUp()
    {
        Debug.Log("heron Show Up. ");
        //gen a heron card
    }

    void otherIbisShowUp()
    {
        Debug.Log("other Ibis Show Up.");
        //gen many ibis npc card
    }

    //////NPC
    
    /////Objects
    void grassSeed()
    {
        Debug.Log("grass seed gened.");
        //gen many grass seed card
    }

    void foodInRiver(GameObject food) //泥鳅、田螺、黄鳝、青蛙以及软体动物。河滩中有鱼、虾、螺、蟹及贝类等食物
    {
       
        Debug.Log(food.name + " gened.");
        //gen many grass seed card
    }

    void arbor() //离居民近、距地面高为宜
    {
        Debug.Log("arbor gened.");
        //gen an arbor seed card
    }
    /////Objects

    ////Others
    ///
    ////Others



}
public static class ListExtenstions
{
    public static void AddMany<T>(this List<T> list, params T[] elements)
    {
        list.AddRange(elements);
    }
}
