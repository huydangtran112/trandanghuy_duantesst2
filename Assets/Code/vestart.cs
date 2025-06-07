using UnityEngine;
using UnityEngine.SceneManagement;

public class vestart : MonoBehaviour
{
    
    public void QuayVeMenu()
    {
        SceneManager.LoadScene("GameManager"); // Đổi tên theo đúng tên scene menu của bạn
    }
    public void GoBack()
    {
        SceneHistoryManager.Instance.GoBack();
    }
}