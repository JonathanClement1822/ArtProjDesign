using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final : MonoBehaviour

{
    private static int Score;
    private static int ScoreFinal;
    public Text ScoreText = null;
    public Text ScoreFinalText = null;

    void Start()
    {
        
        

        Score = Scoring.Pic2;
        ScoreFinal = Scoring.finalVal;
        ScoreText.text = Score.ToString();
        ScoreFinalText.text = ScoreFinal.ToString();
        Debug.Log(Scoring.Pic2);



    }




}
