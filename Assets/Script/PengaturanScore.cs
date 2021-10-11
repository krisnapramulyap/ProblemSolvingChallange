using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PengaturanScore : MonoBehaviour
{
    #region singleton

    private static PengaturanScore _instance;

    public static PengaturanScore Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<PengaturanScore>();
            return _instance;
        }
    }

    #endregion

    private static int score;
    public Text scoreText;

    private void Awake()
    {
        score = 0;
    }

    private void Update()
    {
        scoreText.text = "Score : " + score;
    }

    public void IncrementScore()
    {
        score++;
    }
}