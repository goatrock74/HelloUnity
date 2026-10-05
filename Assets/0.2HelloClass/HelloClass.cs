using UnityEngine;

public class HelloClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animal jack = new Animal();
        //jack은 오브젝트를 가르키는 화살표입니다.
        //new:아무것도 없는 공간에 animal을 새로 하나 탄생시키는 것
        //.:내부의 요소에 접근하겠다라는 의미

        jack.name = "JACK";
        jack.sound = "Bark";
        jack.weight = 4.5f;

        Animal nate = new Animal();
        nate.name = "NATE";
        nate.sound = "Nyaa";
        nate.weight = 1.2f;

        Animal annie = new Animal();
        annie.name = "ANNIE";
        annie.sound = "Wee";
        annie.weight = 0.8f;

        nate = jack;
        //이때 nate가 가르키는 객체는 garbage collection이 지워준다.

        nate.name = "JIMMY";

        Debug.Log(jack.name);
        Debug.Log(jack.sound);

        Debug.Log(nate.name);
        Debug.Log(nate.sound);

        Debug.Log(annie.name);
        Debug.Log(annie.sound);


        //Call by Reference
        //변수:실제 존재하는 무언가가 아니라 실제 존재하는 세상에 있는 진짜 오브젝트를 가르키는 화살표일 뿐이라는 의미


        //pass by reference
        //실존하는 객체를 가르키는 그림자일 뿐이라서 변수를 수정하면 원본이 같이 수정이 돼요
        //왜? 실존하는 객체는 하나뿐이고 변수들은 그 실존하는 친구들을 가리키는 그림자일 뿐이기때문
        //*유의*:"가져와서 쓴다"

        //pass by value
        //변수는 값 그자체입니다. 그렇기에 실존하는 변수는 두가지라 하나의 변수를 수정해도 다른 변수는 영향을 받지않습니다.
        }

    // Update is called once per frame
    void Update()
    {
    }
}

//public 붙이는 이유:코드 내부뿐만아니라 외부에서도 클래스를 확인할수있게 만들려고 / 어떤 오브젝트 밖에서 그 내부에 있는 친구가 보인다는 얘기입니다.
public class Animal
{
    public string name;

    public string sound;

    public float weight;
}
