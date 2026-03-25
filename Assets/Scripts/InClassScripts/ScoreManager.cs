using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //Holde på score
    [SerializeField] private int curTotalScore = 0;

    //Oppdatere score
    //Vise score på skjermen
    [SerializeField] private TMP_Text totalScoreText;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Run the Addscore here
        //AddScore(100);
    }

    //Add score to totalscore
    //Run debuglog to check result
    public void AddScore(int score)
    {
        curTotalScore += score;
        
        totalScoreText.text = curTotalScore.ToString();

        Debug.Log(curTotalScore);
    }
}
