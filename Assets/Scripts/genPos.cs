using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genPos : MonoBehaviour
{
    ///left up:1
    ///right up: 2
    ///right:3
    ///right down: 4
    ///left down:5
    ///left: 6
    public Vector2 thisCo;

    public bool isBoundry;
    public int boundry1;
    public int boundry2;
    public int boundry3;

    /*    public GameObject g1;
        public GameObject g2;
        public GameObject g3;
        public GameObject g4;
        public GameObject g5;
        public GameObject g6;*/


    public List<GameObject> OnThis;

    public string landName;

    listObjOnLand _listObjOnLand;
    List<string> nameHasExist;
    

    void Start()
    {
        _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();

        nameHasExist = new List<string>();

      // claimLandName();
        
    }

/*    void claimLandName()
    {
        // if (gameObject.tag == "land")
        //   if (_listObjOnLand.poolLandName.Count!=0)
        //     {

        int ran;
        ran = Random.Range(0, _listObjOnLand.poolLandName.Count - 1);

        while (!nameHasExist.Contains(_listObjOnLand.poolLandName[ran]))
        {

                landName = _listObjOnLand.poolLandName[ran];
                nameHasExist.Add(_listObjOnLand.poolLandName[ran]);
        }
        //    }
    }*/
}
