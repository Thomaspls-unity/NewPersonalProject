using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public UnityEvent OnPause;
    public UnityEvent OnResume;
    public static GameManager Instance;

    private bool isPaused;

    private void Awake()
    {
        SetSingleton();
    }

    private void SetSingleton()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseScreen()
    {
        if (!isPaused)
        {
            isPaused = true;
            OnPause?.Invoke();
            Time.timeScale = 0f;
        }
        else
        {
            isPaused = false;
            OnResume?.Invoke();
            Time.timeScale = 1f;
        }
    }

    public bool IsPaused()
    {
        return isPaused;
    }

    public void ChangeScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
