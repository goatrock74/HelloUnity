using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image fadeImage;

    private void Start()
    {
        StartCoroutine(FadeIn());
        //인위적으로 정지 불가능
        //StartCoroutine("FadeIn");
        //인위적으로 정지 가능
    }

    //CoreRutine(Unity제공)
    //함수에 처리와 처리사이에 대기 시간을 넣을수있고
    //여러처리를 순차적으로 하는것이 아니라 동시에 병렬로 할수있게해줍니다.

    IEnumerator FadeIn()
    {
        Color startColor = fadeImage.color;

        for(int i = 0;i < 100;i++)
        {
            startColor.a -= 0.01f;
            fadeImage.color = startColor;
            yield return new WaitForSeconds(0.01f);
            //잠시 함수 밖으로 0.01f초간 나갔다
        }
    }
}
