using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtom : MonoBehaviour
{
    private Button buttom;
    private GameManager gameManager;

    public int difficulty;
    void Start()
    {
        buttom = GetComponent<Button>();
        buttom.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
    }

    void Update()
    {
        
    }
}
