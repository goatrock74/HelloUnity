using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class HelloCoreRutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(HelloUnity() );
        StartCoroutine(HiCSharp() );
        Debug.Log("End");
    }

    IEnumerator HelloUnity()
    {
        Debug.Log("Hello");
        yield return new WaitForSeconds(3f);
        Debug.Log("Unity");
    }

    IEnumerator HiCSharp()
    {
        Debug.Log("Hi");
        yield return new WaitForSeconds(5f);
        Debug.Log("CSharp");
    }

    //동기(Sync)
    //함수가 끝나고 다음 함수를 실행하는 것입니다.

    //비동시(ASync)
    //동기와 달리 함수가 시작했음 만을 알려주고 다음 함수를 실행하는것
    //+이렇게하면 함수가 한번에 여러개가 실행될수 있기때문에 멀티스래드 방식이 가능합니다.

    //또한 while(true)해도 실행속도가 무조건적으로 빨라지는것을 막아준다.

    private void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            StopCoroutine("HiCSharp");
            //string으로 실행하는 경우 코르틴을 강제 종료할수있습니다.

            //yield return null;
            //만약 함수 대기시간에 대한 데이터를 주지 않는다면 한프레임을 실행하게된다.
        }
    }
}
