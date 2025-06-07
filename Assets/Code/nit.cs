using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SceneHistoryManager : MonoBehaviour
{
    public static SceneHistoryManager Instance;

    private Stack<string> sceneHistory = new Stack<string>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        string currentScene = scene.name;

        if (sceneHistory.Count > 0)
        {
            string previousScene = sceneHistory.Peek();
            if (previousScene != currentScene)
            {
                sceneHistory.Push(currentScene);
            }
        }
        else
        {
            sceneHistory.Push(currentScene);
        }
    }

    public void GoBack()
    {
        if (sceneHistory.Count > 1)
        {
            sceneHistory.Pop();
            string previousScene = sceneHistory.Peek();
            SceneManager.LoadScene(previousScene);
        }
        else
        {
            Debug.LogWarning("Không có scene trước để quay lại.");
        }
    }
}