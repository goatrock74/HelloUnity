using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPostition;

    public Rigidbody target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Instantiate(target);
        //내가 원하는 오브젝트를 찍어내는 메서드입니다.

        Instantiate(target,spawnPostition.position,spawnPostition.rotation);
        //인스턴스화 할때 생성할 위치,회전을 정할 수있습니다.
        //또한 반환값을 가져온 원본데이터에 따라 달라집니다.
        //예를들면 원본의 Rigidbody를 가져와서 인스턴스화 했다면 Rigidbody를 반환하고
        //원본 그차체를 가져오면 GameObject로 반환합니다.

        //원본을 가져올수도 있지만 원본 게임오브젝트가 가지고있는 타입으로도 원본을 가져올수있습니다.

        //*주의
        //인스턴스화는 주로 프리펩을 대상으로 한다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
