using Unity.VisualScripting;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;//자기 자신이 충돌했는지 않했는지를 알게하는 변수
    public Color touchColor;//닿았을때 바뀌는 색

    private Color originalColor;//원래색
    private MeshRenderer myRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        originalColor = myRenderer.material.color;//원래색 초기화
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //OnTriggerEnter:트리거인 콜라이더와 충돌했을때 자동으로 실행
    //Enter:충돌을 한 그 순간
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            //어떤 컴포넌트가 가지고 있는 모든 변수들은 여기 보이는 모든 변수들은 접근이 가능하다.
            //MeshRenderer>Material에 접근할수 있는것 처럼
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

    //Exit:붙어있다가 떼어질때
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }

    //Stay:충돌하고 있는 혹은 붙어 있는 '동안'
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }
    private void OnCollisionEnter(Collision other)
    //일반 콜라이더와 충돌했을때 자동으로 실행
    {
    }
}
