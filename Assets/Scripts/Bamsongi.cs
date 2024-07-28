using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamsongi : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir); //매개변수 방향으로 힘을 가함
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true; //과녁 접촉 시 오브젝트 정지
        GetComponent<ParticleSystem>().Play(); //파티클 생성
        Destroy(gameObject, 0.8f);
    }

    void Start()
    {
        //Shoot(new Vector3(0, 200, 2000)); //벡터 매개변수로 전달
    }
}
