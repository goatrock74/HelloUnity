using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreAdder : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Start Score " + GameScoreManger.GetInstance().GetScore());
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameScoreManger.GetInstance().AddScore(5);
            Debug.Log(GameScoreManger.GetInstance().GetScore());
        }
    }
}
