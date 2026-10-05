using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 moveDir;
    private Rigidbody playerRigidbody;

    //카멜명명 법:프로그래머들이 편안하고 만들어 놓은 명명법
    //낙타 명맘법
    //클래스,함수이름은 무조건 대문자에서 시작합니다.
    //단어와 단어사이는 첫 번째 단어는 대문자고,그리고 쭉 소음자로 쭉 가다가 새로운 단어가 나오면 대문자로 시작합니다.
    //Underscore는 사용하지 않습니다.

    //변수이름
    //단어와 단어 사이에는 대문자로 구별해 주는데 첫 글자는 소문자로합니다.

    //변수,함수,클래스 앞에 접근지시자를 쓰지 않는경우 private로 암묵적으로 처리합니다.
    //private:바깥에 안보이게 해준다는것 입니다.또한 유니티 인스펙터에서 접근할없습니다.
    //public:바깥에 보여주게 해준다는것 입니다.또한 유니티 인스펙터에서 접근할수있습니다.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    //게임이 처음 시작되었을때 한번
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        //게임오브젝트에 있는 <>안에 있는 타입의 컴포넌트를 찾아준다는 것입니다,
    }

    // Update is called once per frame
    //화면이 한번 깜빡일때 한번 실행
    //영화 초당 24프레임 모바일 1초 30프레임 PC 1초 60FPS
    //콘솔 게임 1초 30프레임
    //1초에 대략 60번 단,사양에 따라 다르다,몇 번 실행되는지는 정해져 있지는 않는다.

    private void FixedUpdate()
    {
        playerRigidbody.linearVelocity = new Vector3(moveDir.x, playerRigidbody.linearVelocity.y, moveDir.y);
    }

    public void OnMove(InputValue value)
    {
        moveDir = value.Get<Vector2>();
    }
}
