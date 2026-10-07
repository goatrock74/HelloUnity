using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    public Vector3 move = new Vector3 (-5, 5, -5);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Vector3 targetPostitin = new Vector3(1, 0, 0);
        
        //transform.position = targetPostitin;//현제위치에 벡터 더하기

        //transform.position = transform.position+move;//현제위치에 벡터를 상대적으로 더하기

        transform.Translate(move);//Translate:벡터의 덧셈,뺄셈을 처리하는 함수
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Move();
        }
    }

    void Move()//move만큼 상대적으로 transform을 증가시키는 함수입니다.
    {
        transform.Translate(move * Time.deltaTime);
        //Translate:transform을 local을 기준으로 평행이동을 한다.
        //transform.Translate(move, Space.World);
        //뒤에 Space를 지정하지 않으면 암시적으로 local로 처린한다.
        //World로 하고 싶다면 Space.World로 바꿔야한다.

        //현제 시간 간격 주기
    }
    //로컬 스페이스(상대적):부모와 나 자신을 기준으로 하는 친구입니다.
    //자기 자신의 부모에 상대적입니다.
    //자신의 회전에 상대적입니다.

    //로컬 스페이스인데 부모가 없는경우에는 월드좌표를 부모로 잠는다.
    //글러볼 스페이스(절대적):게임 세상을 기준으로 하는 절대적인 좌표측입니다.
    //평행 이동은 기본적으로 게임 세상을 기준으로 하는게 아니라 어디까지나 자기 자신의 좌표계를 기준으로 한다.
}
