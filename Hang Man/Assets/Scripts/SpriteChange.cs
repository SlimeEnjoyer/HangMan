using System.Collections;
using System.Collections.Generic;
//using UnityEditor; didn't end up using this so I just commented it out for version history
using UnityEngine;
//using UnityEngine.Animations; same thing with this, didn't end up using it

public class SpriteChange : MonoBehaviour
{
    //this is to grab the gameobject
    public GameObject hangMan;

    //this is to grab the sprites the gameobject will swap to
    public Sprite hangBase;
    public Sprite hang01;
    public Sprite hang02;
    public Sprite hang03;
    public Sprite hang04;
    public Sprite hang05;
    public Sprite hang06;
    public Sprite hang07;
    public Sprite hang08;
    public Sprite hang09;
    public Sprite hang10;

    //this is so that the sprite swapping works, if this is gone, everything implodes
    public SpriteRenderer spriteRenderer;

    //this will be used later, and is really only used to grab the lives from the main script
    private int lives = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this will grab the lives from the main code so that the hangman sprite will change based on the amount of lives that are left.
        lives = hangMan.GetComponent<HangMan>().playerLives;
        if (lives == 10)
        {
            spriteRenderer.sprite = hangBase;
        }
        else if (lives == 9)
        {
            spriteRenderer.sprite = hang01;
        }
        else if (lives == 8)
        {
            spriteRenderer.sprite = hang02;
        }
        else if (lives == 7)
        {
            spriteRenderer.sprite = hang03;
        }
        else if (lives == 6)
        {
            spriteRenderer.sprite = hang04;
        }
        else if (lives == 5)
        {
            spriteRenderer.sprite = hang05;
        }
        else if (lives == 4)
        {
            spriteRenderer.sprite = hang06;
        }
        else if (lives == 3)
        {
            spriteRenderer.sprite = hang07;
        }
        else if (lives == 2)
        {
            spriteRenderer.sprite = hang08;
        }
        else if (lives == 1)
        {
            spriteRenderer.sprite = hang09;
        }
        else if (lives == 0)
        {
            spriteRenderer.sprite = hang10;
        }
    }
}
