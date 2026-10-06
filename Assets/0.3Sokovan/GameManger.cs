using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public GameObject winUI;

    public ItemBox[] itemBoxs;

    public bool isGameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGameOver = false;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            SceneManager.LoadScene("Main");

        if (isGameOver == true) return;

        int count = 0;
        for(int i = 0; i < 3; i++)
        {
            if (itemBoxs[i].isOveraped == true)
            {
                //count = count + 1;
                count ++;
            }
        }

        if(count >= 3)
        {
            Debug.Log("게임 승리!!");
            winUI.SetActive(true);
            isGameOver=true;
        }
    }
}
