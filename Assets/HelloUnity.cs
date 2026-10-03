using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //주석:컴퓨터가 처리하지 않는 라인(메모로 사용)

        //한 줄일때

        /*여러 줄일떄*/

        //콜솔:개발자와 컴퓨터가 대화하는 공간
        //콘솔 출력
        Debug.Log("Hello World");

        //숫자형 변수

        int age = 23;
        int money = -1000;

        Debug.Log(age);
        Debug.Log(money);

        //floating point(부동소수점):점이 둥둥 떠있다는 의미,소숫점을 가지는 실수 [32비트]
        //소수점 아래 7자리까지만 정확하며 그다음 부터는 근사값으로 처리한다.
        float height = 169.12345f;

        //double:float의 두배의 영역을 사용합니다.[64비트]
        //소수점 아래 15자리까지만 정확하며 그다음 부터는 근사값으로 처리한다.
        double pi = 3.14159265359;

        //bool:참(true) 혹은 거짓(false)만 가질수있다.
        bool isBoy = true;
        bool isGirl = false;

        //char(character):한 문자만 가질수있다.
        char grade = 'A';

        //string:문장을 가질수있다.
        string movieTitle = "러브라이브";

        Debug.Log("내 나이는!:" + age);

        Debug.Log("내가 가진 돈은!:" + money);

        Debug.Log("내 키는!:" + height);

        Debug.Log("원주율은!:" + pi);

        Debug.Log("내 성적은!:" + grade);

        Debug.Log("명작 영화!:" + movieTitle);

        Debug.Log("나는 남자인가?:" + isBoy);

        //var:할당하는 값을 기준으로 타입을 정하여 그 타입만을 가질수있다.
        var myName = "I_Jemin";
        //string myName = "I_Jemin";
        var myAge = 23;
        //int myAge = 23;

        Debug.Log("제민의 닉네임" + myName);
    }
}
