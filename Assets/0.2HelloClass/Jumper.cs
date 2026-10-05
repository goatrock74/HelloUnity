using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody rb;//오브젝트를 가르키는 화살표
    //여기서 rb를 수정한다는 의미는 rb와 연결된 Rigidbodt를 수정하겠다는 의미입니다.
    //유니티는 어떠한 기능들을 가진 컴포넌트를 조립한 다음에 미리 만들어진 컴포넌트를 가져와서 쓰겠다는 개념입니다.
    //이변수를 통해서 원하는 컴포넌트를 가져온다음에 그 컴포넌트에 내장 기능을 사용하면 사실은 실존하는 오브젝트가 사용된다는 개념입니다.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(0, 1000, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
