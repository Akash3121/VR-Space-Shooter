/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
/*
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    // Call this method to update the score
    public void UpdateScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    // Update the score UI
    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
*/

using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the Text (TMP) component

    private int score = 0;

    void Start()
    {
        // Initialize the score and update the UI
        UpdateScoreUI();
    }

    // Call this method whenever you want to update the score
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    // Update the UI with the current score
    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
