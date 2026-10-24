using UnityEngine;

public class Dog : MonoBehaviour
{
    public string nickName;

    public float weight;

    //public int count = 0;
    //다이나믹:실시간으로 오브젝트가 찍혀나올 때마다 같이 찍혀나온는 것

    public static int count = 0;
    //스태틱:오브젝트가 찍어낼 때 이 친구는 같이 찍혀나올 수 없다는 것

    private void Awake()
    {
        count++;
    }

    private void Start()
    {
        Bark();
    }

    public void Bark()
    {
        Debug.Log("모든 개들의 수:" + count);
        Debug.Log(nickName + ": Bark");
    }

    //스택틱 함수
    
    public static void ShowAnimalType()
    {
        Debug.Log("이것은 개입니다.");
    }
}
