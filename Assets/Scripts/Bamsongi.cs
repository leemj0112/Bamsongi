using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamsongi : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir); //�Ű����� �������� ���� ����
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true; //���� ���� �� ������Ʈ ����
        GetComponent<ParticleSystem>().Play(); //��ƼŬ ����
        Destroy(gameObject, 0.8f);
    }

    void Start()
    {
        //Shoot(new Vector3(0, 200, 2000)); //���� �Ű������� ����
    }
}
