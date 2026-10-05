using UnityEngine;

public class HelloFunction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float sizeOfCircle = 30f;

        float radius = GetRadius(sizeOfCircle);

        Debug.Log("원의 사이즈: " + sizeOfCircle + "원의 반지름" + radius);
    }

    //Scope:변수가 관측가능한 영역,중괄호가 시작과 끝을 하나의 Scope라고 한다.또한 다른 스코프에서는 그안에 있는 변수를 관측할수없다.

    float GetRadius(float size)
    {
        float pi = 3.14f;

        float tmp = size / pi;

        float radius = Mathf.Sqrt(tmp);

        return radius;
    }
}
