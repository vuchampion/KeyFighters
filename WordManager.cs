using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour{

      public List<Word>  words;

      private bool hasActiveWord;
      private Word activeWord;   // sotres the ActiveWord


    private void Start()
    {

      AddWord();
      AddWord();
      AddWord();

    }

     public void AddWord()
      {

        Word word = new Word(WordGenerator.GetRandomWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter (char letter)
    {
      if (hasActiveWord)   // to check if the letter that we typed is in the sequence and remove it from the word if it is true
        {
            if(activeWord.GetNextLetter() == letter)
            {
                  activeWord.TypeLetter();
            }
        }
        else {
                foreach( Word word in words)
                {

                  if(word.GetNextLetter() == letter )
                    {
                        activeWord = word;
                        hasActiveWord = true;
                        word.TypeLetter();
                        break;

                    }
                }

        }

          if (hasActiveWord && activeWord.WordTyped())
          {
            hasActiveWord = false;
            words.Remove(activeWord);
          }
    }

}
