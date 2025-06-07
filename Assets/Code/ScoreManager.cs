using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public float currentScore = 0f;           // Điểm hiện tại
    public TextMeshProUGUI scoreText;         // Text hiện điểm hiện tại
    public TextMeshProUGUI highScoreText;     // Text hiện điểm cao nhất

    private const string HighScoreKey = "HighScore";

    public void SetScore(float score)
    {
        currentScore = score;

        // Hiện điểm hiện tại
        if (scoreText != null)
            scoreText.text = currentScore.ToString("F1");

        // Kiểm tra và lưu điểm cao nhất
        float savedHigh = PlayerPrefs.GetFloat(HighScoreKey, 0f);
        if (currentScore > savedHigh)
        {
            PlayerPrefs.SetFloat(HighScoreKey, currentScore);
            PlayerPrefs.Save(); // Đừng quên lưu!
        }

        // Hiện điểm cao nhất
        if (highScoreText != null)
        {
            float displayHigh = PlayerPrefs.GetFloat(HighScoreKey, 0f);
            highScoreText.text = displayHigh.ToString("F1");
        }
    }
}
