using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject BaamsongiPrefabs; //����� ������Ʈ

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject Bamsongi = Instantiate(BaamsongiPrefabs); //����� �ν��Ͻ� ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            Bamsongi.GetComponent<Bamsongi>().Shoot(worldDir.normalized * 2000) ; //�������� �ϴ� ������ ���� ����
        }
    }
}
