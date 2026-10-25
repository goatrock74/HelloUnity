using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreSubtrator : MonoBehaviour
{
    private void Update()
    {
        if(Mouse.current.rightButton.wasPressedThisFrame)
        {
            GameScoreManger.GetInstance().AddScore(-2);
            Debug.Log(GameScoreManger.GetInstance().GetScore());
        }
    }
}
