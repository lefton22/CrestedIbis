using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Panda;
using DG.Tweening;


namespace Panda.Ibis
{


    public class MyIbis_eat : MonoBehaviour
    {

        outerAI _outAI;

        List<GameObject> foods_l;
        List<Vector2> v2_foods_l;

        listObjOnLand _listObjOnLand;

        LandGen2 _LandGen2;

        Vector2 v2_nearestFood;

        GameObject _targetPos;
        Vector3 v3_targetPos;

        Animator ani;

        CrestedIbis _CrestedIbis;

        void Start()
        {
            _outAI = GameObject.Find("Values").GetComponent<outerAI>();

            foods_l = new List<GameObject>();
            _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();

            v2_foods_l = new List<Vector2>();

            _LandGen2 = GameObject.Find("LandGenerator").GetComponent<LandGen2>();

            _targetPos = GameObject.Find("Target2");
            v3_targetPos = _targetPos.transform.position;

            _CrestedIbis = GameObject.Find("ibisA").GetComponent<CrestedIbis>();

            ani = transform.parent. gameObject.GetComponent<Animator>();
        }


        void Update()
        {

        }



        ///TASK/////
        ///

        [Task]
        void seekFood()
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
            if (_listObjOnLand.foodOnLand_GO.Count > 0)
            {


                //seek all food obj in the scene
                v2_foods_l = new List<Vector2>(_listObjOnLand.foodOnLand);
                /*            foreach (Vector2 v22 in v2_foods_l)
                            { Debug.Log("v2_foods_l: " + v22); }*/

                /*            GameObject[] foods = GameObject.FindGameObjectsWithTag("food");
                            foods_l.Clear();
                            for (int i = 0; i < foods.Length; i++)
                            {
                                foods_l.Add(foods[i]);
                                Debug.Log("which food in the scene: " + foods_l[i].name);
                            }*/

                //寻找有食物的地点：水田、河滩，go!

                v2_nearestFood = getNearestGrid(gameObject.GetComponent<objV2Pos>().thisV2, _listObjOnLand.foodOnLand);
                Debug.Log("v2_nearestFood: " + v2_nearestFood + " , " + gameObject.GetComponent<objV2Pos>().thisV2
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

                if (gameObject.GetComponent<objV2Pos>().thisV2 == v2_nearestFood) //暂
                {
                    Debug.Log("seek food succeed.");
                    ThisTask.Succeed();
                }


                // Debug.Log("speed: "+ gameObject.GetComponent<Pathfinding.AILerp>().speed);
            }
            if (_listObjOnLand.foodOnLand_GO.Count == 0)
            {

                ThisTask.Succeed();
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



/*
        [Task]
        void eat()
        {
            if (_listObjOnLand.foodOnLand_GO.Count > 0)
            {
                int amount_food;
                amount_food = _listObjOnLand.foodOnLand.Count;
                //吃
                //Destroy the food & 

                //remove it from the food list
                Vector2 v2_ibis;
                //Vector2 v2_food;
                int index_food;
                v2_ibis = gameObject.GetComponent<objV2Pos>().thisV2;
                index_food = _listObjOnLand.foodOnLand.IndexOf(v2_ibis);

                int index2;
                index2 = _LandGen2.LandCos.IndexOf(v2_ibis);
                _listObjOnLand.isObjOnLand[index2] = false;

                full = full + _listObjOnLand.foodOnLand_GO[index_food].GetComponent<objFood>().rich;
                if (full > full_max)
                {
                    full = full_max;
                }

                _listObjOnLand.foodOnLand.Remove(v2_ibis);
                Destroy(_listObjOnLand.foodOnLand_GO[index_food]);
                _listObjOnLand.foodOnLand_GO.Remove(_listObjOnLand.foodOnLand_GO[index_food]);


                //Play pick food animation
                ani.Play("pickFood");

                if (_listObjOnLand.foodOnLand.Count < amount_food)
                { ThisTask.Succeed(); }

                *//*            if (ani.GetBool("hasFood"))
                            { ThisTask.Succeed(); }*//*
            }
            if (_listObjOnLand.foodOnLand_GO.Count == 0)
            {
                lightEat();
                ThisTask.Succeed();
            }
        }*/


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


            nextChild.GetComponent<PandaBehaviour>().enabled = true;
            nextChild.GetComponent<PandaBehaviour>().Reset();

            gameObject.GetComponent<PandaBehaviour>().enabled = false;

            ThisTask.Succeed();
        }



        /////TASK//////
        ///end
        ///

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

        void seekLocation(Vector3 destination)
        {
            _targetPos.transform.DOMove(destination, 0.000001f, false);
            // go 
            ani.Play("ibis_walk");
            _CrestedIbis.ibisMove1();

            //  Debug.Log("move to destination: " + destination);


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
    }
}

