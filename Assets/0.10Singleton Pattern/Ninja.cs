using UnityEngine;

public class Ninja : MonoBehaviour
{
    public static Ninja ninjaking;

    public string ninjaName;

    public bool isKing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(isKing)
        {
            ninjaking = this;
        }
        //클래스에 모두에게 공유할 대상을 넣어서 객체 접근하여 갑을 가져온는게 아니라 클래스에 접근해서 값을 받아온다. 

        Debug.Log("My Name: " + ninjaName+",Ninja King"+ ninjaking.ninjaName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
