
using UnityEngine;

public class GameScoreManger : MonoBehaviour
{
    //싱글톤 패턴에서는 Scene상에 무조건 하나만 존재한다는 확정이 있어야 됩니다.
    public static GameScoreManger GetInstance()
    {
        if(instance == null)
        {
            instance = FindFirstObjectByType<GameScoreManger>();
            //instance 찾아서 GameScoreManger형 할당하기

            if(instance == null )
            {
                GameObject container = new GameObject("ScoreManger");
                container.AddComponent<GameScoreManger>();
                //만얀 GameScoreManger가 씬에 없다면 새로 만들어서 instance에 할당해라
            }
        }

        return instance;
    }

    private static GameScoreManger instance;

    private int score = 0;

    private void Awake()
    {
        instance = this;
    }

    //싱글톤 패턴
    //유일하게 단 하나만 존재하고 모든 객체들이 접근 가능해야 할때 사용가능

    //왜? 사용하는 가?
    //복잡한 과정(드래그앤드롭 or 검색)통해서 찾아가는 방법이 아니라 클래스에 직접들어가서 접근하는 방법이 있습니다.

    //public GameScoreManger scoreManger;각각 할당하지 않고
    //GameScoreManger.instance.GetScore()
    //GameScoreManger.instance.AddScore()
    //=> ScoreSubrator,ScoreAdder

    private void Start()
    {
        if(instance != null)
        {
            if(instance !=  this)
            {
                Destroy(gameObject);
                //만약 여러개가 instance가 있는데 자기 자신이 클래스 자기 자신이 아니라면 삭제하기
            }
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int newScore)
    {
        score = score + newScore;
    }

}
