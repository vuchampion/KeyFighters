﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text; // reference to text element


    public void SetWord (string word)

  {
      text.text = word;

  }

  public void RemoveLetter()
  {

    text.text = text.text.Remove(0,1);
    text.color = Color.red;


  }

  public void RemoveWord()
  {
    Destroy(gameObject);

  }

  



}
