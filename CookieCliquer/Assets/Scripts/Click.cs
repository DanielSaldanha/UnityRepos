using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Click : MonoBehaviour
{
    //CLICKER
    public Text ScoreText;
    public float currentScore, hitPower, scoreIncreasedPerSecond, x;
    //SHOP
    public int shop1Prize, DuplicatePrize, cavalo;
    public Text shop1txt, DuplicateTxt;
    //AMOUNT
    public Text amount1txt;
    public float amount1profit;

    void Start()
    {
        //CLICKER & SHOP
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        DuplicatePrize = 25;
        shop1Prize = 25;
        x = 0f;

        //RESET
        PlayerPrefs.DeleteAll();

        //LOAD
        currentScore = PlayerPrefs.GetInt("currentScore", 0);
        hitPower = PlayerPrefs.GetInt("hitPower", 1);
        DuplicatePrize = PlayerPrefs.GetInt("DuplicatePrize", 25);
        shop1Prize = PlayerPrefs.GetInt("shop1Prize", 25);
        x = PlayerPrefs.GetInt("x", 0);

    }

    void Update()
    {
        //CLICKER
        ScoreText.text = (int)currentScore + "";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        //SHOP
        shop1txt.text = + shop1Prize + " PREÇO";
      
        //AMOUNT
        amount1txt.text = " Speed " + amount1profit + "/s";

        //HIT UPGRADE
        DuplicateTxt.text = +DuplicatePrize + " PREÇO";

        //SAVE
        PlayerPrefs.SetInt("currentScore", (int)currentScore);
        PlayerPrefs.SetInt("hitPower", (int)hitPower);
        PlayerPrefs.SetInt("DuplicatePrize", (int)DuplicatePrize);
        PlayerPrefs.SetInt("shop1Prize", (int)shop1Prize);
        PlayerPrefs.SetInt("x", (int)x);   

    }
    //HIT
    //chamada/executada nos botoes
    public void click()
    {
        currentScore += hitPower;
    }
    public void OOOO_Potencia()
    {
        if(currentScore >= DuplicatePrize)
        {
            currentScore -= DuplicatePrize;
            DuplicatePrize += 25;
            hitPower++;
        }
    }
    public void shop1()
    {
        if (currentScore >= shop1Prize)
        {
            currentScore -= shop1Prize;
            
            amount1profit += 1;
            x += 1;
            shop1Prize += 25;
        }
    }
    public void cavalos()
    {
        if(currentScore >= 2050)
        {

        }
    }
   
}
