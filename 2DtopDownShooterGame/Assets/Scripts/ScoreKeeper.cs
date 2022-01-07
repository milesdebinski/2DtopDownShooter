using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
  [SerializeField] int score;


  void Start()
  {

  }

  void Update()
  {

  }

  public int GetScore()
  {
    return score;
  }


  public void AddScore(int add)
  {
    score += add;
  }

  public void ResetScore()
  {
    score = 0;
  }
}
