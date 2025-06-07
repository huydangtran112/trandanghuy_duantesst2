using UnityEngine;
using UnityEngine.SceneManagement;

public class sangmanchoi : MonoBehaviour
{
    public void SangChonManChoi()
    {
        SceneManager.LoadScene("manchoi"); // Đổi tên theo đúng tên scene menu của bạn
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

