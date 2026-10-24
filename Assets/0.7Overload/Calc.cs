using UnityEngine;

public class Calc : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Sum(1, 1));
        Debug.Log(Sum(-5, 8,10));
        Debug.Log(Sum(1.3f, 1.6f));
    }

    public int Sum(int a,int b)
    {
        return a + b;
    }

    //오버로드:함수의 이름은 똑같이 하되 다른 버전의 함수를 만드는 것
    //*주의:이름은 똑같이 하되 오버로드르르 사용할때는 꼭 입력이나 출력둘 중에 하나는 형태가 달라야 한다.

    //출력이 다른 경우
    public float Sum(float a,float b)
    {
        return a + b;
    }

    //입력이 다른 경우
    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
}
