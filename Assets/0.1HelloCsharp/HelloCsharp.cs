using UnityEngine;
using UnityEngine.UIElements;

public class HelloCsharp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //형변환(캐스팅)
        int height = 170;
        float heightDetail = 170.3f;

        //암묵적인 형변환(자동 형변환):잃어버리는 정보가 없으면
        heightDetail = height;//실수 집합이 정수집합보다 작기때문에 형변을 할필요가 없다.

        //형변환(직접 명시해야 하는 경우):읿어버리는 정보가 있으면
        height = (int)heightDetail;
        //height = heightDetail;
        //이렇게 하면 잃어버리는 정보가 생긴다.

        //조건문 if문
        bool isBoy = true;

        if(isBoy == true)
        {
            Debug.Log("나는 남자다."); 
        }
        else
        {
            Debug.Log("나는 여자다.");
        }

        if (isBoy != false)
        {
            Debug.Log("나는 남자다.");
        }

        if(!isBoy)
        {
            Debug.Log("나는 여자다.");
        }
        //관계연산자
        //== 왼쪽 오른쪽 값이 같을때
        //!= 왼쪽 오른쪽 값이 다를때
        //< 미만
        //<= 이하
        //> 초과
        //>= 이상

        int love = 40;

        if(love < 50)
        {
            Debug.Log("배드엔딩");
        }
        else
        {
            Debug.Log("해피엔딩");
        }

        int age = 17;

        //if (age >= 60)
        //{
        //    Debug.Log("일을 하면 안된다");
        //}
        //if(age <= 17)
        //{
        //    Debug.Log("일을 하면 안된다.");
        //}

        //or || 혹은
        //A || B,A 혹은 B 둘중에 하나라도 참이면 => 참
        if (age >= 60 || age <= 17)
        {
            Debug.Log("일을 하면 안된다");
        }

        //AND && 그리고
        //A && B,A 그리고 B,두개가 모두 참 => 참
        if(age > 17 && age < 60)
        {
            Debug.Log("일할 나이");
        }


        if(age <= 7)
        {
            Debug.Log("유치원에 간다.");
        }
        else if(age < 12)
        {
            Debug.Log("초등학교로 간다.");
        }//age >= 12 그리고 age <15
        else if(age < 15)
        {
            Debug.Log("중학교로 간다.");
        }
        else if(age <18)
        {
            Debug.Log("고등학교로 간다.");
        }
        else
        {
            Debug.Log("성인");
        }

        Debug.Log("! true =" + (!true));

        //swith 분기문

        int year = 2017;

        switch(year)
        {
            case 2012:
                Debug.Log("레미제라블");
                break;

            case 2015:
                Debug.Log("러브라이브");
                break;

            case 2016:
                Debug.Log("곡성");
                break;

            case 2017:
                Debug.Log("트랜스포머5");
                break;

            default:
                Debug.Log("년도가 해당사항 없음");
                break;
        }

        //루프문 Loop 반복문

        //for 문
        // 초기화;조건;업데이트
        //i > 0,1,2,3,4,5,6,7,8,9
        //순번을 매길때 유용하다.
        for(int i = 0;i < 10;i++)
        {
            Debug.Log("현제 수번: " + i);

        }
        Debug.Log("끝");
        
        //while문 조건에 맞족할때까지 돌아간다.
        bool isShot = false;
        int index = 0;
        int luckNumer = 4;
        while(isShot == false)
        {
            index = index + 1;
            Debug.Log("현제시도: " + index);

            if (index == luckNumer)
            {
                Debug.Log("총알에 맞았다!");
                isShot = true;
            }
            else
            {
                Debug.Log("총알에 맞지 않았다.");
            }
        }

        //Do while:한번은 실행하고 그다음부터 조건에서 거른다.
        do
        {
            Debug.Log("DO~While");
        } while (isShot == false);
    }
}
