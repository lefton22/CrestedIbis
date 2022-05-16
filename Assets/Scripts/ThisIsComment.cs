using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisIsComment : MonoBehaviour
{
    /// <summary>
    /// Attach this script to any gameObject for which you want to put a note.
    /// </summary>

        [TextArea]
        public string Notes = "Comment Here."; // Do not place your note/comment here. 
                                               // Enter your note in the Unity Editor.
    
}
