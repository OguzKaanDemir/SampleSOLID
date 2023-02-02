using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _ins;

    public static GameManager Ins
    {
        get
        {
            if (_ins == null)
                _ins = FindObjectOfType<GameManager>();

            return _ins;
        }
    }
    [Header("Panels")]
    public GameObject gameFinishPanel;
    public GameObject gamePanel;
    public GameObject startPanel;

    [Space]
    public GameObject player;
    public GameObject platform;
    public int score;

    [HideInInspector] public bool isGameOver;
    [HideInInspector] public bool isGameStarted;
    [HideInInspector] public bool isGameRunning;
    public Action onGameStart;
    public Action onPlayerLose;

    public void OnGameStart()
    {
        if (isGameStarted) return;
        isGameStarted = true;
        isGameRunning = true;

        onGameStart?.Invoke();
    }

    public void OnPlayerLose()
    {
        if (isGameOver) return;
        isGameOver = true;
        isGameRunning = false;

        onPlayerLose?.Invoke();
    }
}
