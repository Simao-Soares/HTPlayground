using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore;
    public Text playerScoreText;

    public void PlayerScores(){
        playerScore = playerScore + 5;
        this.playerScoreText.text = playerScore.ToString();
        Debug.Log("+5 pontos");
        //ResetPos?
    }



}
