using System;
using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class HangMan : MonoBehaviour
{
    public int playerLives = 10;

    public float wordChosen = 1f; //Random.Range(1, 10);

    public int letterCount = 0;

    public string chosenWord = "";

    public char letterGuess = '0';

    public bool gameOver = false;

    public Text gameStatis;

    public int streak = 0;

    public char letter01 = '0';
    public char letter02 = '0';
    public char letter03 = '0';
    public char letter04 = '0';
    public char letter05 = '0';
    public char letter06 = '0';
    public char letter07 = '0';
    public char letter08 = '0';
    public char letter09 = '0';

    public bool evenLetterWord = true;

    public GameObject Letter01;
    public GameObject Letter02;
    public GameObject Letter03;
    public GameObject Letter04;
    public GameObject Letter05;
    public GameObject Letter06;
    public GameObject Letter07;
    public GameObject Letter08;
    public GameObject Letter09;

    public GameObject textBox01;
    public GameObject textBox02;
    public GameObject textBox03;
    public GameObject textBox04;
    public GameObject textBox05;
    public GameObject textBox06;
    public GameObject textBox07;
    public GameObject textBox08;
    public GameObject textBox09;
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

        //letters that are not used BHJQVXZ

        if (buttonClicked == 1)
            letterGuess = 'a';
            if (wordChosen == 1)
            {
                
            }
            else if (wordChosen == 2)
            {
                
            }
            else if (wordChosen == 3)
            {
                
            }
            else if (wordChosen == 4)
            {
                
            }
            else if (wordChosen == 5)
            {
                
            }
            else if (wordChosen == 6)
            {
                
            }
            else if (wordChosen == 7)
            {
                
            }
            else if (wordChosen == 8)
            {
                
            }
            else if (wordChosen == 9)
            {
                
            }
            else if (wordChosen == 10)
            {
                
            }
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
            evenLetterWord = false;
            letter01 = '0';
            letter02 = '0';
            letter03 = 'T';
            letter04 = 'E';
            letter05 = 'M';
            letter06 = 'P';
            letter07 = 'T';
            letter08 = '0';
            letter09 = '0';
        }
        else if (wordChosen == 2)
        {
            chosenWord = "Glory";
            Debug.Log(chosenWord);
            letterCount = 5;
            evenLetterWord = false;
            letter01 = '0';
            letter02 = '0';
            letter03 = 'G';
            letter04 = 'L';
            letter05 = 'O';
            letter06 = 'R';
            letter07 = 'Y';
            letter08 = '0';
            letter09 = '0';
        }
        else if (wordChosen == 3)
        {
            chosenWord = "Radical";
            Debug.Log(chosenWord);
            letterCount = 7;
            evenLetterWord = false;
            letter01 = '0';
            letter02 = 'R';
            letter03 = 'A';
            letter04 = 'D';
            letter05 = 'I';
            letter06 = 'C';
            letter07 = 'A';
            letter08 = 'L';
            letter09 = '0';
        }
        else if (wordChosen == 4)
        {
            chosenWord = "Pocket";
            Debug.Log(chosenWord);
            letterCount = 6;
            evenLetterWord = true;
            letter01 = '0';
            letter02 = '0';
            letter03 = 'P';
            letter04 = 'O';
            letter05 = 'C';
            letter06 = 'K';
            letter07 = 'E';
            letter08 = 'T';
            letter09 = '0';
        }
        else if (wordChosen == 5)
        {
            chosenWord = "Cart";
            Debug.Log(chosenWord);
            letterCount = 4;
            evenLetterWord = true;
            letter01 = '0';
            letter02 = '0';
            letter03 = '0';
            letter04 = 'C';
            letter05 = 'A';
            letter06 = 'R';
            letter07 = 'T';
            letter08 = '0';
            letter09 = '0';
        }
        else if (wordChosen == 6)
        {
            chosenWord = "Respect";
            Debug.Log(chosenWord);
            letterCount = 7;
            evenLetterWord = false;
            letter01 = '0';
            letter02 = 'R';
            letter03 = 'E';
            letter04 = 'S';
            letter05 = 'P';
            letter06 = 'E';
            letter07 = 'C';
            letter08 = 'T';
            letter09 = '0';
        }
        else if (wordChosen == 7)
        {
            chosenWord = "Proposal";
            Debug.Log(chosenWord);
            letterCount = 8;
            evenLetterWord = true;
            letter01 = '0';
            letter02 = 'P';
            letter03 = 'R';
            letter04 = 'O';
            letter05 = 'P';
            letter06 = 'O';
            letter07 = 'S';
            letter08 = 'A';
            letter09 = 'L';
        }
        else if (wordChosen == 8)
        {
            chosenWord = "Return";
            Debug.Log(chosenWord);
            letterCount = 6;
            evenLetterWord = true;
            letter01 = '0';
            letter02 = '0';
            letter03 = 'R';
            letter04 = 'E';
            letter05 = 'T';
            letter06 = 'U';
            letter07 = 'R';
            letter08 = 'N';
            letter09 = '0';
        }
        else if (wordChosen == 9)
        {
            chosenWord = "Fog";
            Debug.Log(chosenWord);
            letterCount = 3;
            evenLetterWord = false;
            letter01 = '0';
            letter02 = '0';
            letter03 = '0';
            letter04 = 'F';
            letter05 = 'O';
            letter06 = 'G';
            letter07 = '0';
            letter08 = '0';
            letter09 = '0';
        }
        else if (wordChosen == 10)
        {
            chosenWord = "Wisecrack";
            Debug.Log(chosenWord);
            letterCount = 9;
            evenLetterWord = false;
            letter01 = 'W';
            letter02 = 'I';
            letter03 = 'S';
            letter04 = 'E';
            letter05 = 'C';
            letter06 = 'R';
            letter07 = 'A';
            letter08 = 'C';
            letter09 = 'K';
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

    /*void Example(string[] args)
    {
        string str = chosenWord;
        char value = letterGuess;
        bool result = str.Contains(value);
        Debug.Log(result);
    }*/
}
