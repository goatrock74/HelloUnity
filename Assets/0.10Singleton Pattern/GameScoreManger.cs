
using UnityEngine;

public class GameScoreManger : MonoBehaviour
{
    public static GameScoreManger instance;

    private int score = 0;

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int newScore)
    {
        score = score + newScore;
    }
}
