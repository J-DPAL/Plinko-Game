using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText; // UI Text element for score display
    private int score01 = 0;

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int points)
    {
        score01 += points;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score01;
    }
}
