using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
  [SerializeField] TextMeshProUGUI scoreText;
  ScoreKeeper scoreKeeper;

  void Awake()
  {
    scoreKeeper = FindObjectOfType<ScoreKeeper>();
  }
  void Start()
  {
    Debug.Log(scoreText.text);
    scoreText.text = "Your Score was:\n" + scoreKeeper.GetScore();
  }
}
