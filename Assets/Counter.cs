using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public static Counter Instance;

    private void Awake()
    {
        Instance = this;
    }

    int score = 0;
    int addedScore = 1;
    public TMP_Text text;

    public void AddScore()
    {
        score = score + addedScore;
        text.text = score.ToString();
    }
}
