using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Word : MonoBehaviour
{
    public GameObject hangMan;
    public GameObject Letter01;
    public GameObject Letter02;
    public GameObject Letter03;
    public GameObject Letter04;
    public GameObject Letter05;
    public GameObject Letter06;
    public GameObject Letter07;
    public GameObject Letter08;
    public GameObject Letter09;

    public char letter001 = '0';
    public char letter002 = '0';
    public char letter003 = '0';
    public char letter004 = '0';
    public char letter005 = '0';
    public char letter006 = '0';
    public char letter007 = '0';
    public char letter008 = '0';
    public char letter009 = '0';
    private bool evenLetters = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        evenLetters = hangMan.GetComponent<HangMan>().evenLetterWord;
        letter001 = hangMan.GetComponent<HangMan>().letter01;
        letter002 = hangMan.GetComponent<HangMan>().letter02;
        letter003 = hangMan.GetComponent<HangMan>().letter03;
        letter004 = hangMan.GetComponent<HangMan>().letter04;
        letter005 = hangMan.GetComponent<HangMan>().letter05;
        letter006 = hangMan.GetComponent<HangMan>().letter06;
        letter007 = hangMan.GetComponent<HangMan>().letter07;
        letter008 = hangMan.GetComponent<HangMan>().letter08;
        letter009 = hangMan.GetComponent<HangMan>().letter09;

        if (evenLetters == true)
        {
            transform.position = new Vector3(463, 375.7f, 0);
        }
        else
        {
            transform.position = new Vector3(478, 375.7f, 0);
        }
        if (letter001 == '0')
        {
            //get the object (panel?), get the Image component of that panel
            Letter01.GetComponent<Image>().enabled = false;
        }
        else
        {
            Letter01.GetComponent<Image>().enabled = true;
        }
        if (letter002 == '0')
        {
            Letter02.GetComponent<Image>().enabled = false;
        }
        else
        {
            Letter02.GetComponent<Image>().enabled = true;
        }
        if (letter003 == '0')
        {
            Letter03.GetComponent<Image>().enabled = false;
        }
        else
        {
            Letter03.GetComponent<Image>().enabled = true;
        }
        if (letter004 == '0')
        {
            Letter04.GetComponent<Image>().enabled = false;
        }
        else
        {
            Letter04.GetComponent<Image>().enabled = true;
        }
        if (letter005 == '0')
        {
            Letter05.GetComponent<Image>().enabled = false;
        }
        else
        {
            Letter05.GetComponent<Image>().enabled = true;
        }
        if (letter006 == '0')
        {
            Letter06.GetComponent<Image>().enabled = false;
        }
        else
        {
            Letter06.GetComponent<Image>().enabled = true;
        }
        if (letter007 == '0')
        {
            Letter07.GetComponent<Image>().enabled = false;
        }
        else
        {
            Letter07.GetComponent<Image>().enabled = true;
        }
        if (letter008 == '0')
        {
            Letter08.GetComponent<Image>().enabled = false;
        }
        else
        {
            Letter08.GetComponent<Image>().enabled = true;
        }
        if (letter009 == '0')
        {
            Letter09.GetComponent<Image>().enabled = false;
        }
        else
        {
            Letter09.GetComponent<Image>().enabled = true;
        }
    }
}
