using System;
using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting; this isn't needed, but I'm leaving this as a comment to show verison history
using UnityEngine;
//using UnityEngine.SocialPlatforms; this is also not needed either, but again, imma leave this here to show version history, cuz lol
using UnityEngine.UI;

public class HangMan : MonoBehaviour
{
    public int playerLives = 10;

    public float wordChosen = 1f; //Random.Range(1, 10); you guessed it, version history, there's a fair bit of that in here, ngl. oh well. This tried to make it so wordChosen was random immediately, buuuut that didn't quite work so I had to change it a bit so the randomisation part starts at the "void Start" instead of before the script starts.

    public int letterCount = 0;

    public int numberLetterCorrect = 0;

    public string chosenWord = "";

    public char letterGuess = '0';

    public bool gameOver = false;

    public Text gameStatis;

    public int streak = 0;

    //this is for the characters for each random word
    public char letter01 = '0';
    public char letter02 = '0';
    public char letter03 = '0';
    public char letter04 = '0';
    public char letter05 = '0';
    public char letter06 = '0';
    public char letter07 = '0';
    public char letter08 = '0';
    public char letter09 = '0';

    public bool evenLetterWord = true; //this is to see if the the number of letters are even

    //this is for the letters for the random word
    public GameObject Letter01;
    public GameObject Letter02;
    public GameObject Letter03;
    public GameObject Letter04;
    public GameObject Letter05;
    public GameObject Letter06;
    public GameObject Letter07;
    public GameObject Letter08;
    public GameObject Letter09;

    //this is for the text of each letter for each random word, because the border thingy around each letter of the random words are just a button with the button component removed. I did that cause I liked the look.
    public Text textBox01;
    public Text textBox02;
    public Text textBox03;
    public Text textBox04;
    public Text textBox05;
    public Text textBox06;
    public Text textBox07;
    public Text textBox08;
    public Text textBox09;


    //this is for each and every single letter of the alphebet (hopefully I didn't miss a letter) this will make it so when you click on a letter and it's wrong, the letter turns red.
    public GameObject letterA;
    public GameObject letterB;
    public GameObject letterC;
    public GameObject letterD;
    public GameObject letterE;
    public GameObject letterF;
    public GameObject letterG;
    public GameObject letterH;
    public GameObject letterI;
    public GameObject letterJ;
    public GameObject letterK;
    public GameObject letterL;
    public GameObject letterM;
    public GameObject letterN;
    public GameObject letterO;
    public GameObject letterP;
    public GameObject letterQ;
    public GameObject letterR;
    public GameObject letterS;
    public GameObject letterT;
    public GameObject letterU;
    public GameObject letterV;
    public GameObject letterW;
    public GameObject letterX;
    public GameObject letterY;
    public GameObject letterZ;

    // Start is called before the first frame update
    void Start()
    {
        //this makes the wordChosen a random number between 1 and 10, and the number wordChosen will be set to will determine what random word is chosen which will allow you to guess what that randomly chosen word is so that you can complete and beat this game about guesses each letter of a randomly chosen word.
        wordChosen = UnityEngine.Random.Range(1, 10);
        Debug.Log(wordChosen);
        
        
        //Code didn't work as intended initially, left to show version history or something like that, idk
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

    //when you click a button, this will run
    public void ClickButton(int buttonClicked)
    {
        //life tester to see if the life system works (spoilers (or not) it works :D)
        if (buttonClicked == -1)
            playerLives--;
        else if (buttonClicked == -2)
            playerLives++;

        //letter inputs so that you can guess what letter is in the randomly chosen word
        if (buttonClicked == 1)
        {
            letterGuess = 'a';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterA.GetComponent<Image>().color = new Color(255, 0, 0);
                letterA.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterA.GetComponent<Image>().color = new Color(255, 0, 0);
                letterA.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                textBox03.text = "A";
                textBox07.text = "A";
                letterA.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterA.GetComponent<Image>().color = new Color(255, 0, 0);
                letterA.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                textBox05.text = "A";
                letterA.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterA.GetComponent<Image>().color = new Color(255, 0, 0);
                letterA.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                textBox08.text = "A";
                letterA.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterA.GetComponent<Image>().color = new Color(255, 0, 0);
                letterA.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterA.GetComponent<Image>().color = new Color(255, 0, 0);
                letterA.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                textBox07.text = "A";
                letterA.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 2)
        {
            letterGuess = 'b';
            Debug.Log(letterGuess);
            playerLives--;
            letterB.GetComponent<Image>().color = new Color(255, 0, 0);
            letterB.GetComponent<Button>().enabled = false;
        }
        else if (buttonClicked == 3)
        {
            letterGuess = 'c';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterC.GetComponent<Image>().color = new Color(255, 0, 0);
                letterC.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterC.GetComponent<Image>().color = new Color(255, 0, 0);
                letterC.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                textBox06.text = "C";
                letterC.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                textBox05.text = "C";
                letterC.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                textBox04.text = "C";
                letterC.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                textBox07.text = "C";
                letterC.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterC.GetComponent<Image>().color = new Color(255, 0, 0);
                letterC.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterC.GetComponent<Image>().color = new Color(255, 0, 0);
                letterC.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterC.GetComponent<Image>().color = new Color(255, 0, 0);
                letterC.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                textBox05.text = "C";
                textBox08.text = "C";
                letterC.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 4)
        {
            letterGuess = 'd';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterD.GetComponent<Image>().color = new Color(255, 0, 0);
                letterD.GetComponent <Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterD.GetComponent<Image>().color = new Color(255, 0, 0);
                letterD.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                textBox04.text = "D";
                letterD.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterD.GetComponent<Image>().color = new Color(255, 0, 0);
                letterD.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterD.GetComponent<Image>().color = new Color(255, 0, 0);
                letterD.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterD.GetComponent<Image>().color = new Color(255, 0, 0);
                letterD.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterD.GetComponent<Image>().color = new Color(255, 0, 0);
                letterD.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterD.GetComponent<Image>().color = new Color(255, 0, 0);
                letterD.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterD.GetComponent<Image>().color = new Color(255, 0, 0);
                letterD.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterD.GetComponent<Image>().color = new Color(255, 0, 0);
                letterD.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 5)
        {
            letterGuess = 'e';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                textBox04.text = "E";
                letterE.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterE.GetComponent<Image>().color = new Color(255, 0, 0);
                letterE.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterE.GetComponent<Image>().color = new Color(255, 0, 0);
                letterE.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                textBox07.text = "E";
                letterE.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterE.GetComponent<Image>().color = new Color(255, 0, 0);
                letterE.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                textBox03.text = "E";
                textBox06.text = "E";
                letterE.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterE.GetComponent<Image>().color = new Color(255, 0, 0);
                letterE.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                textBox04.text = "E";
                letterE.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterE.GetComponent<Image>().color = new Color(255, 0, 0);
                letterE.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                textBox04.text = "E";
                letterE.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 6)
        {
            letterGuess = 'f';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterF.GetComponent<Image>().color = new Color(255, 0, 0);
                letterF.GetComponent <Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterF.GetComponent<Image>().color = new Color(255, 0, 0);
                letterF.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterF.GetComponent<Image>().color = new Color(255, 0, 0);
                letterF.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterF.GetComponent<Image>().color = new Color(255, 0, 0);
                letterF.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterF.GetComponent<Image>().color = new Color(255, 0, 0);
                letterF.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterF.GetComponent<Image>().color = new Color(255, 0, 0);
                letterF.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterF.GetComponent<Image>().color = new Color(255, 0, 0);
                letterF.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterF.GetComponent<Image>().color = new Color(255, 0, 0);
                letterF.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                textBox04.text = "F";
                letterF.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterF.GetComponent<Image>().color = new Color(255, 0, 0);
                letterF.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 7)
        {
            letterGuess = 'g';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterG.GetComponent<Image>().color = new Color(255, 0, 0);
                letterG.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                textBox03.text = "G";
                letterG.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterG.GetComponent<Image>().color = new Color(255, 0, 0);
                letterG.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterG.GetComponent<Image>().color = new Color(255, 0, 0);
                letterG.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterG.GetComponent<Image>().color = new Color(255, 0, 0);
                letterG.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterG.GetComponent<Image>().color = new Color(255, 0, 0);
                letterG.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterG.GetComponent<Image>().color = new Color(255, 0, 0);
                letterG.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterG.GetComponent<Image>().color = new Color(255, 0, 0);
                letterG.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                textBox06.text = "G";
                letterG.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterG.GetComponent<Image>().color = new Color(255, 0, 0);
                letterG.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 8)
        {
            letterGuess = 'h';
            Debug.Log(letterGuess);
            playerLives--;
            letterH.GetComponent<Image>().color = new Color(255, 0, 0);
            letterH.GetComponent<Button>().enabled = false;
        }
        else if (buttonClicked == 9)
        {
            letterGuess = 'i';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterI.GetComponent<Image>().color = new Color(255, 0, 0);
                letterI.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterI.GetComponent<Image>().color = new Color(255, 0, 0);
                letterI.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                textBox05.text = "I";
                letterI.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterI.GetComponent<Image>().color = new Color(255, 0, 0);
                letterI.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterI.GetComponent<Image>().color = new Color(255, 0, 0);
                letterI.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterI.GetComponent<Image>().color = new Color(255, 0, 0);
                letterI.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterI.GetComponent<Image>().color = new Color(255, 0, 0);
                letterI.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterI.GetComponent<Image>().color = new Color(255, 0, 0);
                letterI.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterI.GetComponent<Image>().color = new Color(255, 0, 0);
                letterI.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                textBox02.text = "I";
                letterI.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 10)
        {
            letterGuess = 'j';
            Debug.Log(letterGuess);
            playerLives--;
            letterJ.GetComponent<Image>().color = new Color(255, 0, 0);
            letterJ.GetComponent<Button>().enabled = false;
        }
        else if (buttonClicked == 11)
        {
            letterGuess = 'k';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterK.GetComponent<Image>().color = new Color(255, 0, 0);
                letterK.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterK.GetComponent<Image>().color = new Color(255, 0, 0);
                letterK.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterK.GetComponent<Image>().color = new Color(255, 0, 0);
                letterK.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                textBox06.text = "K";
                letterK.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterK.GetComponent<Image>().color = new Color(255, 0, 0);
                letterK.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterK.GetComponent<Image>().color = new Color(255, 0, 0);
                letterK.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterK.GetComponent<Image>().color = new Color(255, 0, 0);
                letterK.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterK.GetComponent<Image>().color = new Color(255, 0, 0);
                letterK.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterK.GetComponent<Image>().color = new Color(255, 0, 0);
                letterK.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                textBox09.text = "K";
                letterK.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 12)
        {
            letterGuess = 'l';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterL.GetComponent<Image>().color = new Color(255, 0, 0);
                letterL.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                textBox04.text = "L";
                letterL.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                textBox08.text = "L";
                letterL.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterL.GetComponent<Image>().color = new Color(255, 0, 0);
                letterL.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterL.GetComponent<Image>().color = new Color(255, 0, 0);
                letterL.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterL.GetComponent<Image>().color = new Color(255, 0, 0);
                letterL.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                textBox09.text = "L";
                letterL.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterL.GetComponent<Image>().color = new Color(255, 0, 0);
                letterL.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterL.GetComponent<Image>().color = new Color(255, 0, 0);
                letterL.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterL.GetComponent<Image>().color = new Color(255, 0, 0);
                letterL.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 13)
        {
            letterGuess = 'm';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                textBox05.text = "M";
                letterM.GetComponent<Button>().enabled = false;

            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterM.GetComponent<Image>().color = new Color(255, 0, 0);
                letterM.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterM.GetComponent<Image>().color = new Color(255, 0, 0);
                letterM.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterM.GetComponent<Image>().color = new Color(255, 0, 0);
                letterM.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterM.GetComponent<Image>().color = new Color(255, 0, 0);
                letterM.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterM.GetComponent<Image>().color = new Color(255, 0, 0);
                letterM.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterM.GetComponent<Image>().color = new Color(255, 0, 0);
                letterM.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterM.GetComponent<Image>().color = new Color(255, 0, 0);
                letterM.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterM.GetComponent<Image>().color = new Color(255, 0, 0);
                letterM.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterM.GetComponent<Image>().color = new Color(255, 0, 0);
                letterM.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 14)
        {
            letterGuess = 'n';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterN.GetComponent<Image>().color = new Color(255, 0, 0);
                letterN.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterN.GetComponent<Image>().color = new Color(255, 0, 0);
                letterN.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterN.GetComponent<Image>().color = new Color(255, 0, 0);
                letterN.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterN.GetComponent<Image>().color = new Color(255, 0, 0);
                letterN.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterN.GetComponent<Image>().color = new Color(255, 0, 0);
                letterN.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterN.GetComponent<Image>().color = new Color(255, 0, 0);
                letterN.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterN.GetComponent<Image>().color = new Color(255, 0, 0);
                letterN.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                textBox08.text = "N";
                letterN.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterN.GetComponent<Image>().color = new Color(255, 0, 0);
                letterN.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterN.GetComponent<Image>().color = new Color(255, 0, 0);
                letterN.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 15)
        {
            letterGuess = 'o';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterO.GetComponent<Image>().color = new Color(255, 0, 0);
                letterO.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                textBox05.text = "O";
                letterO.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterO.GetComponent<Image>().color = new Color(255, 0, 0);
                letterO.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                textBox04.text = "O";
                letterO.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterO.GetComponent<Image>().color = new Color(255, 0, 0);
                letterO.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterO.GetComponent<Image>().color = new Color(255, 0, 0);
                letterO.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                textBox04.text = "O";
                textBox07.text = "O";
                letterO.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterO.GetComponent<Image>().color = new Color(255, 0, 0);
                letterO.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                textBox05.text = "O";
                letterO.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterO.GetComponent<Image>().color = new Color(255, 0, 0);
                letterO.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 16)
        {
            letterGuess = 'p';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                textBox06.text = "P";
                letterP.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterP.GetComponent<Image>().color = new Color(255, 0, 0);
                letterP.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterP.GetComponent<Image>().color = new Color(255, 0, 0);
                letterP.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                textBox03.text = "P";
                letterP.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterP.GetComponent<Image>().color = new Color(255, 0, 0);
                letterP.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                textBox05.text = "P";
                letterP.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                textBox02.text = "P";
                textBox05.text = "P";
                letterP.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterP.GetComponent<Image>().color = new Color(255, 0, 0);
                letterP.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterP.GetComponent<Image>().color = new Color(255, 0, 0);
                letterP.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterP.GetComponent<Image>().color = new Color(255, 0, 0);
                letterP.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 17)
        {
            letterGuess = 'q';
            Debug.Log(letterGuess);
            playerLives--;
            letterQ.GetComponent<Image>().color = new Color(255, 0, 0);
            letterQ.GetComponent<Button>().enabled = false;
        }
        else if (buttonClicked == 18)
        {
            letterGuess = 'r';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterR.GetComponent<Image>().color = new Color(255, 0, 0);
                letterR.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                textBox06.text = "R";
                letterR.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                textBox02.text = "R";
                letterR.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterR.GetComponent<Image>().color = new Color(255, 0, 0);
                letterR.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                textBox06.text = "R";
                letterR.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                textBox02.text= "R";
                letterR.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                textBox03.text = "R";
                letterR.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                textBox03.text = "R";
                textBox07.text = "R";
                letterR.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterR.GetComponent<Image>().color = new Color(255, 0, 0);
                letterR.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                textBox06.text= "R";
                letterR.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 19)
        {
            letterGuess = 's';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterS.GetComponent<Image>().color = new Color(255, 0, 0);
                letterS.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterS.GetComponent<Image>().color = new Color(255, 0, 0);
                letterS.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterS.GetComponent<Image>().color = new Color(255, 0, 0);
                letterS.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterS.GetComponent<Image>().color = new Color(255, 0, 0);
                letterS.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterS.GetComponent<Image>().color = new Color(255, 0, 0);
                letterS.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                textBox04.text = "S";
                letterS.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                textBox07.text = "S";
                letterS.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterS.GetComponent<Image>().color = new Color(255, 0, 0);
                letterS.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterS.GetComponent<Image>().color = new Color(255, 0, 0);
                letterS.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                textBox03.text = "S";
                letterS.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 20)
        {
            letterGuess = 't';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                textBox03.text = "T";
                textBox07.text = "T";
                letterT.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterT.GetComponent<Image>().color = new Color(255, 0, 0);
                letterT.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterT.GetComponent<Image>().color = new Color(255, 0, 0);
                letterT.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                textBox08.text = "T";
                letterT.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                textBox07.text = "T";
                letterT.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                textBox08.text = "T";
                letterT.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterT.GetComponent<Image>().color = new Color(255, 0, 0);
                letterT.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                textBox05.text = "T";
                letterT.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterT.GetComponent<Image>().color = new Color(255, 0, 0);
                letterT.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterT.GetComponent<Image>().color = new Color(255, 0, 0);
                letterT.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 21)
        {
            letterGuess = 'u';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterU.GetComponent<Image>().color = new Color(255, 0, 0);
                letterU.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterU.GetComponent<Image>().color = new Color(255, 0, 0);
                letterU.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {

                playerLives--;
                letterU.GetComponent<Image>().color = new Color(255, 0, 0);
                letterU.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterU.GetComponent<Image>().color = new Color(255, 0, 0);
                letterU.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterU.GetComponent<Image>().color = new Color(255, 0, 0);
                letterU.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterU.GetComponent<Image>().color = new Color(255, 0, 0);
                letterU.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterU.GetComponent<Image>().color = new Color(255, 0, 0);
                letterU.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                textBox06.text = "U";
                letterU.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterU.GetComponent<Image>().color = new Color(255, 0, 0);
                letterU.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterU.GetComponent<Image>().color = new Color(255, 0, 0);
                letterU.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 22)
        {
            letterGuess = 'v';
            Debug.Log(letterGuess);
            playerLives--;
            letterV.GetComponent<Image>().color = new Color(255, 0, 0);
            letterV.GetComponent<Button>().enabled = false;
        }
        else if (buttonClicked == 23)
        {
            letterGuess = 'w';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterW.GetComponent<Image>().color = new Color(255, 0, 0);
                letterW.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                playerLives--;
                letterW.GetComponent<Image>().color = new Color(255, 0, 0);
                letterW.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {

                playerLives--;
                letterW.GetComponent<Image>().color = new Color(255, 0, 0);
                letterW.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterW.GetComponent<Image>().color = new Color(255, 0, 0);
                letterW.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterW.GetComponent<Image>().color = new Color(255, 0, 0);
                letterW.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterW.GetComponent<Image>().color = new Color(255, 0, 0);
                letterW.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterW.GetComponent<Image>().color = new Color(255, 0, 0);
                letterW.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterW.GetComponent<Image>().color = new Color(255, 0, 0);
                letterW.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterW.GetComponent<Image>().color = new Color(255, 0, 0);
                letterW.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                textBox01.text = "W";
                letterW.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 24)
        {
            letterGuess = 'x';
            Debug.Log(letterGuess);
            playerLives--;
            letterX.GetComponent<Image>().color = new Color(255, 0, 0);
            letterX.GetComponent<Button>().enabled = false;
        }
        else if (buttonClicked == 25)
        {
            letterGuess = 'y';
            Debug.Log(letterGuess);
            if (wordChosen == 1)
            {
                playerLives--;
                letterY.GetComponent<Image>().color = new Color(255, 0, 0);
                letterY.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 2)
            {
                textBox07.text = "Y";
                letterY.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 3)
            {
                playerLives--;
                letterY.GetComponent<Image>().color = new Color(255, 0, 0);
                letterY.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 4)
            {
                playerLives--;
                letterY.GetComponent<Image>().color = new Color(255, 0, 0);
                letterY.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 5)
            {
                playerLives--;
                letterY.GetComponent<Image>().color = new Color(255, 0, 0);
                letterY.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 6)
            {
                playerLives--;
                letterY.GetComponent<Image>().color = new Color(255, 0, 0);
                letterY.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 7)
            {
                playerLives--;
                letterY.GetComponent<Image>().color = new Color(255, 0, 0);
                letterY.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 8)
            {
                playerLives--;
                letterY.GetComponent<Image>().color = new Color(255, 0, 0);
                letterY.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 9)
            {
                playerLives--;
                letterY.GetComponent<Image>().color = new Color(255, 0, 0);
                letterY.GetComponent<Button>().enabled = false;
            }
            else if (wordChosen == 10)
            {
                playerLives--;
                letterY.GetComponent<Image>().color = new Color(255, 0, 0);
                letterY.GetComponent<Button>().enabled = false;
            }
        }
        else if (buttonClicked == 26)
        {
            letterGuess = 'z';
            Debug.Log(letterGuess);
            playerLives--;
            letterZ.GetComponent<Image>().color = new Color(255, 0, 0);
            letterZ.GetComponent<Button>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //This determines what word is used depending on the number
        if (wordChosen == 1)
        {
            chosenWord = "Tempt";
            //Debug.Log(chosenWord);
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
            //Debug.Log(chosenWord);
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
            //Debug.Log(chosenWord);
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
            //Debug.Log(chosenWord);
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
            //Debug.Log(chosenWord);
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
            //Debug.Log(chosenWord);
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
            //Debug.Log(chosenWord);
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
            //Debug.Log(chosenWord);
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
            //Debug.Log(chosenWord);
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
            //Debug.Log(chosenWord);
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

        //this makes sure that the player's lives don't go above 10 or below 0
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

        //this is to make sure that the "Game Over" text doesn't cover the hang man graphic
        if (gameOver == true)
        {
            gameStatis.text = "Game Over";
        }
        else
        {
            gameStatis.text = "";
        }
    }


    //I was originally going to try and get this game working throw a way that I don't fully understand but might've been faster, buuuut idk if I would've been able to expain it, plus extra work is fun
    /*void Example(string[] args)
    {
        string str = chosenWord;
        char value = letterGuess;
        bool result = str.Contains(value);
        Debug.Log(result);
    }*/
}
