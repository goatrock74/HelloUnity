using UnityEngine;

public class Ball : MonoBehaviour
{
    public ParticleSystem explosionParticle;

    public AudioSource explosionAudio;

    public float maxDamage = 100f;
    //최대 데미지

    public float explosionForce = 1000f;
    //주변에 게임 오브젝트에 주는 힘

    public float lifeTime = 10f;
    //공의 생명주기

    public float explosionRadius = 20f;
    //공의 폭발 반경

    private void Start()
    {
        Destroy(gameObject, lifeTime);
        //10초의 공의 생명주기
    }

    private void OnTriggerEnter(Collider other) 
    {
        explosionParticle.transform.parent = null;
        //부모에서 벗어나기

        explosionParticle.Play();
        explosionAudio.Play();

        Destroy(explosionParticle.gameObject, explosionParticle.main.duration);
        Destroy(gameObject);
        
    }
}
