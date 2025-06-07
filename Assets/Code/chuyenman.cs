using UnityEngine;
using UnityEngine.SceneManagement;

public class chuyenman : MonoBehaviour
{
    public void ChuyenSangHuongDan()
    {
        SceneManager.LoadScene("huongdanchoi"); // Đảm bảo scene này có tên đúng
    }
}
