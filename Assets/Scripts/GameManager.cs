using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    int[] playerScores = { 0, 0 };

    public int MaxScore;

    public GameObject playerScoreUIObject_0;
    public GameObject playerScoreUIObject_1;
    public GameObject BallObject;
    Ball ballComponent;
    TextMeshProUGUI[] playerScoresUI = {null, null};


    void Awake()
    {
        InitScoreUI();

        ballComponent = BallObject.GetComponent<Ball>();
    }

    void InitScoreUI()
    {
        playerScoresUI[0] = playerScoreUIObject_0.GetComponent<TextMeshProUGUI>();
        playerScoresUI[1] = playerScoreUIObject_1.GetComponent<TextMeshProUGUI>();

        playerScoresUI[0].text = playerScores[0].ToString();
        playerScoresUI[1].text = playerScores[1].ToString();
    }

    void UpdatePlayerScoreUI(int playerIndex)
    {
        playerScoresUI[playerIndex].text = playerScores[playerIndex].ToString();
    }

    // Update is called once per frame
    public void PlayerScored(int playerID)
    {
        playerScores[playerID] += 1;
        UpdatePlayerScoreUI(playerID);

        if(playerScores[playerID] == MaxScore)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        ballComponent.Reset();
        ballComponent.Launch();
    }

    bool CheckPlayerVictory(int playerIndex)
    {
        return playerScores[playerIndex] >= MaxScore;
    }
}
