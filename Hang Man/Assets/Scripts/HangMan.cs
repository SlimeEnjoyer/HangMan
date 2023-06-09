using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class HangMan : MonoBehaviour
{
    public int playerLives = 10;

    public float wordChosen = 1f; //Random.Range(1, 10);

    public int letterCount = 0;

    public string chosenWord = "";

    public char letterGuess = 'a';

    public bool gameOver = false;

    public Text gameStatis;

    // Start is called before the first frame update
    void Start()
    {
        wordChosen = UnityEngine.Random.Range(1, 10);
        Debug.Log(wordChosen);
        //Code didn't work as intended initially

        /*if (wordChosen == 1)
        {
            chosenWord = "Tempt";
            Debug.Log(chosenWord);
        }
        else if (wordChosen == 2)
        {
            chosenWord = "Glory";
            Debug.Log(chosenWord);
        }
        else if (wordChosen == 3)
        {
            chosenWord = "Radical";
            Debug.Log(chosenWord);
        }
        else if (wordChosen == 4)
        {
            chosenWord = "Pocket";
            Debug.Log(chosenWord);
        }
        else if (wordChosen == 5)
        {
            chosenWord = "Cart";
            Debug.Log(chosenWord);
        }
        else if (wordChosen == 6)
        {
            chosenWord = "Respect";
            Debug.Log(chosenWord);
        }
        else if (wordChosen == 7)
        {
            chosenWord = "Proposal";
            Debug.Log(chosenWord);
        }
        else if (wordChosen == 8)
        {
            chosenWord = "Return";
            Debug.Log(chosenWord);
        }
        else if (wordChosen == 9)
        {
            chosenWord = "Fog";
            Debug.Log(chosenWord);
        }
        else if (wordChosen == 10)
        {
            chosenWord = "Wisecrack";
            Debug.Log(chosenWord);
        }*/
    }

    public void ClickButton(int buttonClicked)
    {
        if (buttonClicked == -1)
        playerLives--;
        else if (buttonClicked == -2)
            playerLives++;

        if (buttonClicked == 1)
            letterGuess = 'a';
        else if (buttonClicked == 2)
            letterGuess = 'b';
        else if (buttonClicked == 3)
            letterGuess = 'c';
        else if (buttonClicked == 4)
            letterGuess = 'd';
        else if (buttonClicked == 5)
            letterGuess = 'e';
        else if (buttonClicked == 6)
            letterGuess = 'f';
        else if (buttonClicked == 7)
            letterGuess = 'g';
        else if (buttonClicked == 8)
            letterGuess = 'h';
        else if (buttonClicked == 9)
            letterGuess = 'i';
        else if (buttonClicked == 10)
            letterGuess = 'j';
        else if (buttonClicked == 11)
            letterGuess = 'k';
        else if (buttonClicked == 12)
            letterGuess = 'l';
        else if (buttonClicked == 13)
            letterGuess = 'm';
        else if (buttonClicked == 14)
            letterGuess = 'n';
        else if (buttonClicked == 15)
            letterGuess = 'o';
        else if (buttonClicked == 16)
            letterGuess = 'p';
        else if (buttonClicked == 17)
            letterGuess = 'q';
        else if (buttonClicked == 18)
            letterGuess = 'r';
        else if (buttonClicked == 19)
            letterGuess = 's';
        else if (buttonClicked == 20)
            letterGuess = 't';
        else if (buttonClicked == 21)
            letterGuess = 'u';
        else if (buttonClicked == 22)
            letterGuess = 'v';
        else if (buttonClicked == 23)
            letterGuess = 'w';
        else if (buttonClicked == 24)
            letterGuess = 'x';
        else if (buttonClicked == 25)
            letterGuess = 'y';
        else if (buttonClicked == 26)
            letterGuess = 'z';
    }

    // Update is called once per frame
    void Update()
    {
        if (wordChosen == 1)
        {
            chosenWord = "Tempt";
            Debug.Log(chosenWord);
            letterCount = 5;
        }
        else if (wordChosen == 2)
        {
            chosenWord = "Glory";
            Debug.Log(chosenWord);
            letterCount = 5;
        }
        else if (wordChosen == 3)
        {
            chosenWord = "Radical";
            Debug.Log(chosenWord);
            letterCount = 7;
        }
        else if (wordChosen == 4)
        {
            chosenWord = "Pocket";
            Debug.Log(chosenWord);
            letterCount = 6;
        }
        else if (wordChosen == 5)
        {
            chosenWord = "Cart";
            Debug.Log(chosenWord);
            letterCount = 4;
        }
        else if (wordChosen == 6)
        {
            chosenWord = "Respect";
            Debug.Log(chosenWord);
            letterCount = 7;
        }
        else if (wordChosen == 7)
        {
            chosenWord = "Proposal";
            Debug.Log(chosenWord);
            letterCount = 8;
        }
        else if (wordChosen == 8)
        {
            chosenWord = "Return";
            Debug.Log(chosenWord);
            letterCount = 6;
        }
        else if (wordChosen == 9)
        {
            chosenWord = "Fog";
            Debug.Log(chosenWord);
            letterCount = 3;
        }
        else if (wordChosen == 10)
        {
            chosenWord = "Wisecrack";
            Debug.Log(chosenWord);
            letterCount = 9;
        }

        if(playerLives >= 10)
        {
            playerLives = 10;
        }

        if (playerLives <= 0)
        {
            playerLives = 0;
        }

        if (playerLives == 0)
        {
            gameOver = true;
        }
        else
        {
            gameOver = false;
        }

        if (gameOver == true)
        {
            gameStatis.text = "Game Over";
        }
        else
        {
            gameStatis.text = "";
        }
    }

    void Example(string[] args)
    {
        string str = chosenWord;
        char value = letterGuess;
        bool result = str.Contains(value);
        Debug.Log(result);
    }
}
