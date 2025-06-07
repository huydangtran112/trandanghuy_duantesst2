using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeLimit = 10f; // Thời gian giới hạn (giây)
    private float timer = 0f;

    public TextMeshProUGUI timerText; // Kéo Text UI vào đây trong Inspector

    private bool gameEnded = false;

    public float GetTimeLeft()
    {
        return Mathf.Max(0f, timeLimit - timer);
    }

    void Update()
    {
        if (gameEnded) return;

        timer += Time.deltaTime;

        float timeLeft = Mathf.Max(0, timeLimit - timer);

        // Cập nhật text mỗi frame
        if (timerText != null)
        {
            timerText.text = timeLeft.ToString("F1");
        }

        if (timer >= timeLimit)
        {
            gameEnded = true;
            SceneManager.LoadScene("Losser"); // Hết giờ thì thua
        }
    }

    public void EndGameEarly()
    {
        gameEnded = true;
    }
}
