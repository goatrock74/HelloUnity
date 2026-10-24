using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreSubtrator : MonoBehaviour
{
    public GameScoreManger scoreManger;

    private void Update()
    {
        if(Mouse.current.rightButton.wasPressedThisFrame)
        {
            scoreManger.AddScore(-2);
            Debug.Log(scoreManger.GetScore());
        }
    }
}
