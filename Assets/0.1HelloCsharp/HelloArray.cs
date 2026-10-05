using UnityEngine;

public class HelloArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //배열:여러개의 값을 하나의 변수로 다룬다.
        int[] scores = new int[10];
        //이렇게 배열의 공간을 정하면 바꿀수없다.

        //scores[0][1][2][3][4][5][6][7][8][9]

        scores[0] = 90;
        scores[1] = 45;
        scores[2] = 60;
        scores[3] = 70;
        scores[4] = 56;
        scores[5] = 80;
        scores[6] = 90;
        scores[7] = 100;
        scores[8] = 45;
        scores[9] = 14;

        Debug.Log(scores[3]);

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("학생"+i+"번째의 점수"+scores[i]);
        }

        //out of index:범위를 벗어났다.
        scores[10] = 30;

        scores = new int[20];
    }
}
