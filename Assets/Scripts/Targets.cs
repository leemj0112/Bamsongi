using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public int TargetCount = 1;

    private void OnCollisionEnter(Collision collision)
    {
        TargetCount--;
    }
}
