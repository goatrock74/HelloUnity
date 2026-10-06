using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.Rotate(60, 60, 60);
        //transform  컴포넌트에 접근할수있는 키워드
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(60 * Time.deltaTime, 60*Time.deltaTime, 60*Time.deltaTime);
        //Time.deltaTime은 화면이 한번 깜박이는 시간 = 한 프레임의 시간
        //화면을 60번 깜박이면(초당 60프레임)
    }
}
