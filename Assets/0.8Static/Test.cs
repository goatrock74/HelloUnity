using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Test Dog의 총 개수: " + Dog.count);
        Dog.ShowAnimalType();
    }
    //스태틱 변수또는 메서드는 클래스에 있기때문에 클래스. 만 써도 사용할수있습니다.
}
