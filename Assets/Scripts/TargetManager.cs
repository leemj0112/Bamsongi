using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        GameObject tar = Instantiate(target);
        tar.transform.position = new Vector3(0,0,10);
    }
}
