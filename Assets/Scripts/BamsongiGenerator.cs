using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject BaamsongiPrefabs; //밤송이 오브젝트

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject Bamsongi = Instantiate(BaamsongiPrefabs); //밤송이 인스턴스 생성
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //스크린 클릭
            Vector3 worldDir = ray.direction; //좌표 변환
            Bamsongi.GetComponent<Bamsongi>().Shoot(worldDir.normalized * 2000) ; //날리고자 하는 방향의 백터 전달
        }
    }
}
