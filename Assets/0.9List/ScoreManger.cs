
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.LightTransport;

public class ScoreManger : MonoBehaviour
{
    //배열
    //선언
    //public int[] scores = new int[10];

    //새로운 배열 할당
    //scores = new int[11];

    //기존의 배열에 칸이 늘어난다면 기존의 값을 지우고 새로운 배열을 만들어야 합니다.
    //이런 배열의 크기를 자유롭게 늘리지 못하는 이유들 때문에 리스트를 사용합니다.

    //List는 클래스이기 때문에 기존의 C#에서는 제공하지 않는 기능입니다. -> "using System.Collections.Generic;" 쓰기
    //선언 : 리스트의 크기를 지정하지 않습니다.
    public List<int> scores = new List<int>();


    private void Start()
    {
        int score0 = 45;
        int score1 = 60;
        int score2 = 75;

        scores.Add(score0);
        scores.Add(score1);
        scores.Add(score2);

        scores.Remove(60);
        //List의 값을 명시해서 지워줍니다.

        Debug.Log(scores[0]);
        // List에서 값을 가져오기

        scores[0] = score0;
        //List 인덱스를 사용해서 값을 수정하기

        //scores.Count
        //List의 크기를 받아오기
    }

    private void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            int randomNumber = Random.Range(0, 100);
            scores.Add(randomNumber);
            //리스트는 자유롭게 List의 크기를 Add라는 함수를 통해서 크기를 자유롭게 추가 할수있습니다.
        }

        if(Keyboard.current.aKey.wasPressedThisFrame)
        {
            scores.RemoveAt(3);
            //리스트는 자유롭게 List의 크기를 RemoveAt라는 함수를 통해서 크기를 자유롭게 삭제 할수있습니다.
            //Trim:실시간으로  리스트의 공백의 뒤에 있는 칸들로 채워준다는 것입니다.
        }
    }
}
