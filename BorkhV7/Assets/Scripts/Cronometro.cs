using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public TMP_Text texsec;
    public TMP_Text texmim;
    public float sec;
    public int mim;
    public int limit;
    public int fol;
    public int folseg;
    public int folter;
    public static bool parart;
    public GameObject folha;
    public GameObject folhaSeg;
    public GameObject folhater;
    public GameObject timegame;


    void Start()
    {
        parart = false;


    }


    void FixedUpdate()
    {
        if(parart == false)
        {
        texsec.text = sec.ToString("00");
        texmim.text = mim.ToString("00");
        sec += Time.deltaTime;
        }
        if(sec >= limit)
        {
            mim++;
            sec = 0 + 1;

        
        }
        if(mim >= fol)
        {
            folha.SetActive(false);

        }
        if(mim >= folseg)
        {
            folhaSeg.SetActive(false);

        }
        if(mim >= folter)
        {
            folhater.SetActive(false);

        }
        if(parart == true)
        {
            timegame.SetActive(false);



        }


        
    }
}
