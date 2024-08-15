using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMe : MonoBehaviour
{
    public int TargetCount = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bamsongi")
        {
            TargetCount = 0;
        }
    }

    private void Update()
    {
        if (TargetCount == 0)
        {
            Destroy(gameObject);
            TargetCount = 0;
            return;
        }
    }
}
