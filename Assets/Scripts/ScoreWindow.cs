using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreWindow : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void Awake() {
        scoreText = transform.Find("ScoreText").GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        scoreText.text = GameHandler.GetScore().ToString();
    }
}
