using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour{

 public WordManager wordManager;
 
    // Update is called onceper frame
    void Update()
    {
        foreach( char letter in Input.inputString)
        {
           wordManager.TypeLetter(letter);

      //    Debug.Log(letter); // gets the input from keyboard and displays ti
        }
    }
}
