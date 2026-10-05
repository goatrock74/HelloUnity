using UnityEngine;

public class HelloMath : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    /*
        int a = 5;

        int b = 7;

        int sum = a + b;

        Debug.Log(sum);

        sum = a - b;

        Debug.Log(sum);

        Debug.Log(a * b);

        Debug.Log(a / b);

        Debug.Log(b / a);

        Debug.Log(a % b);

        Debug.Log(b % a);
    */

    /*
        int i  = 0;

        i = i + 1;

        Debug.Log(i);

        i++;
        //i = i +1;

        Debug.Log(i);

        i = i - 1;

        Debug.Log(i);

        i--;
        //i = i-1;

        Debug.Log(i);

        i++;

        Debug.Log(i);
    */

        //0
        int i = 0;
        //1
        Debug.Log(++i);
        //2
        Debug.Log(i);
        //2
        Debug.Log(i++);

        int j = 10;


        j += 5;
        //j = j + 5;

        Debug.Log(j);
        j -= 5;
        //j = j - 5;

        Debug.Log(j);
        j *= 5;
        //j = j * 5;

        Debug.Log(j);
        j /= 5;
        //j = j / 5;

        Debug.Log(j);
        j %= 5;
        //j = j % 5;

        Debug.Log(j);
    }
}
