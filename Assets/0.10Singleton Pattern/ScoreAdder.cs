using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreAdder : MonoBehaviour
{
    public GameScoreManger scoreManger;

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            scoreManger.AddScore(5);
            Debug.Log(scoreManger.GetScore());
        }
    }
}
