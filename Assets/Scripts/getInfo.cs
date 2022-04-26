using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class getInfo : MonoBehaviour
{
    int _gender;
    int _full;
    int _sprite;

    bool _isSingle;
    bool _isMate;
    GameObject _mate;

    string s_gender;
    string s_full;
    string s_sprite;

    string s_isSingle;
    string s_isMate;
    string s_mate;

        void Start()
        {
        ResetProperties();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ResetProperties() // wehn Start, after meetOpSex..?
        {
            _gender = transform.parent.GetComponent<NPCIbis>().gender;
            _full = transform.parent.GetComponent<NPCIbis>().full;
            _sprite = transform.parent.GetComponent<NPCIbis>().sprite;
            _isSingle = transform.parent.GetComponent<NPCIbis>().isSingle;
            _isMate = transform.parent.GetComponent<NPCIbis>().isMate;
            _mate = transform.parent.GetComponent<NPCIbis>().mate;

            if (_gender == 1)
            { s_gender = "F"; }
            if (_gender == 2)
            { s_gender = "M"; }

            if (_full == 0)
            { s_full = "starve "; }
            if (_full == 1)
            { s_full = "full "; }

            if (_sprite == 0)
            { s_sprite = "tired "; }

            if (_sprite == 1)
            { s_sprite = "energy"; }

            if (_isSingle)
            { s_isSingle = "single "; }
            if (!_isSingle)
            { s_isSingle = "not single"; }

            if (_isMate)
            { s_isMate = "has mated "; }
            if (!_isMate)
            { s_isMate = "not mate"; }

            if (_mate != null)
            { s_mate = "Mate: " + _mate.name; }
            if (_mate == null)
            { s_mate = "Mate: none"; }


            gameObject.GetComponent<TMPro.TextMeshPro>().text =
                s_gender + "\r\n" + s_full + "\r\n" + s_sprite
                + "\r\n" + s_isSingle + "\r\n" + s_isMate + "\r\n" + s_mate;
        }
    }
