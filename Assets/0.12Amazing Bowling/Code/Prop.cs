using UnityEngine;

public class Prop : MonoBehaviour
{
    public int score = 5;

    public ParticleSystem explosionParticle;

    public float hp = 10f;

    public void Takedamage(float damage)
    {
        hp -= damage;

        if(hp <= 0 )
        {
            ParticleSystem instance = Instantiate(explosionParticle,transform.position,transform.rotation);
            //자신의 위치와 회전에서 파티클만들기
            Destroy(instance.gameObject, instance.main.duration);
            //파티클 시템 삭제하기
            AudioSource explosionAudio = instance.GetComponent<AudioSource>();
            //새로 생성한 오브젝트에서 오디소스 가져오기
            explosionAudio.Play();
            //실행

            gameObject.SetActive(false);
            //게임 오브젝트 끄기
        }
    }
}
