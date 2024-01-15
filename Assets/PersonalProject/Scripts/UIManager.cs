using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("UI SYSTEM")]
    [SerializeField] private Button retryBtn;
    [SerializeField] private Button menuBtn;


    
    // Start is called before the first frame update
    void Start()
    {
        retryBtn.onClick.AddListener(ReloadGame);
    }

    private void ReloadGame()
    {
        GameManager.Instance.ChangeScene("GameScene");
    }
}
