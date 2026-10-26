using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShooterRotater : MonoBehaviour
{
    private enum RotateState
    {
        Idle,Vertical,Horizontal,Ready
    }
    //정해지 상수 값들에 이름을 붙여 사용하는 자료형입니다.

    private RotateState state = RotateState.Idle;

    public float verticalRotateSpeed = 360f;

    public float horizontalRotateSpeed = 360f;
    //회전의 속도 verticalRotateSpeed,horizontal

    private void Update()
    {
       switch(state)
       {
            case RotateState.Idle:
                if (Mouse.current.leftButton.wasPressedThisFrame)
                {
                    state = RotateState.Horizontal;
                }
                break;
            case RotateState.Horizontal:
                if (Mouse.current.leftButton.IsPressed())
                {
                    transform.Rotate(new Vector3(0, horizontalRotateSpeed * Time.deltaTime, 0));
                }
                else if (Mouse.current.leftButton.wasReleasedThisFrame)
                {
                    state = RotateState.Vertical;
                }
                break;
            case RotateState.Vertical:
                if (Mouse.current.leftButton.IsPressed())
                {
                    transform.Rotate(new Vector3(verticalRotateSpeed * Time.deltaTime, 0, 0));
                }
                else if (Mouse.current.leftButton.wasReleasedThisFrame)
                {
                    state = RotateState.Ready;
                }
                break;
            case RotateState.Ready:
                break;
       }
    }
}
