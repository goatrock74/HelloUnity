using UnityEngine;

public class SetRotation : MonoBehaviour
{
    public Transform targetTransform;


    //쿼터니언 (x,y,z,w)
    //사용하는 이유:어느 축이든 90도 회전을 하면 축이 겹치며 축의 정보가 소실되기 때문에(짐볼락)
    //4차원을 사용하여 소실된 축을 보충한다.
    void Start()
    {
        Quaternion newRotation = Quaternion.Euler(new Vector3(60, 60, 60));

        Vector3 direction = targetTransform.position - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        //회전한 방향으로 얼굴이 가는 방향을 쳐다보는 방향으로 자기 자신의 회전을 설정합니다.

        Quaternion aRotation = Quaternion.Euler(new Vector3(60, 0, 0));

        Quaternion bRotation = Quaternion.Euler(new Vector3(90, 0, 0));

        Quaternion midRotation = Quaternion.Lerp(aRotation, bRotation,0.5f);
        //두 개의 값을 정하면 두 개의 회전을 정하면 그 사이에 중간값을 가져올 수가 있습니다.
        //a     |     b
        //0    0.5    1
        transform.rotation = targetRotation;

        Quaternion finalRotation = Quaternion.Euler(new Vector3(45, 0, 0));

        transform.Rotate(new Vector3(30, 0, 0));
        //현제 위치에서 45도 회전을 더하는 메서드

        Quaternion originalRoatiation = transform.rotation;

        Vector3 originalRoatationInVector3 = originalRoatiation.eulerAngles;
        //쿼터니언의  값을 Vector3형으로 바꾼 값입니다.

        Vector3 targetRotationVec = originalRoatationInVector3 + new Vector3(30, 0, 0);

        Quaternion originalRotation = Quaternion.Euler(new Vector3(30,0, 0));

        Quaternion plusRotation = Quaternion.Euler(new Vector3(30,0, 0));

        Quaternion resulRotation = originalRotation * plusRotation;
        //쿼터니언은 행열이라 곱을 통해 더한다.


        //*주의
        //회전을 할때는 나를 중심으로 하는 로컬스페이스로 해야한다.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
