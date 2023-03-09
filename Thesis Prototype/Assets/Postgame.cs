using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Postgame : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI tmpAccuracy;
    [SerializeField]
    TextMeshProUGUI tmpDeath;
    //[SerializeField]
    //TextMeshProUGUI tmpTime;

    private void OnEnable() {
        tmpAccuracy.SetText($"Your overall accuracy in answering code bot is {LearningModuleManager.instance.ComputeAccuracy()}%");
        tmpDeath.SetText($"You died: {LearningModuleManager.instance.totalDeaths} times");

    }
}
