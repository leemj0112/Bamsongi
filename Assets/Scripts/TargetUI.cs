using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetUI : MonoBehaviour
{
    [SerializeField] private GameObject targets;
    public int Count;
    public Text TargetCountTxt;

    void Update()
    {
        Count = targets.GetComponent<TargetMe>().TargetCount;
        TargetCountTxt.text = $"남은 타겟 수: {Count}";

        if(Count == 0)
        {
            TargetCountTxt.text = "클리어!";
        }
    }
}
