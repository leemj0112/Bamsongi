using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetUI : MonoBehaviour
{
    public GameObject targets;
    public Text TargetCountTxt;
    void Update()
    {
        TargetCountTxt.text = $"남은 타겟 수: {0}";
    }
}
