using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class HangMan : MonoBehaviour
{
    public int playerLives = 10;

    public float wordChosen = 1f; //Random.Range(1, 10);

    public int letterCount = 0;

    public string chosenWord = "";

    // Start is called before the first frame update
    void Start()
    {
        wordChosen = Random.Range(1, 10);
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
        if (buttonClicked == 1)
        playerLives--;
        else if (buttonClicked == 2)
            playerLives++;
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
    }
}
