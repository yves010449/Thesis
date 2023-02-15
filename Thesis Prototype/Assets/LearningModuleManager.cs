using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class LearningModuleManager : MonoBehaviour
{
    public static LearningModuleManager instance;

    [SerializeField]
    TextMeshProUGUI tmp;
    public int learningModuleCollected = 0;
    [SerializeField]
    int maxlearningModule = 1;

    public UnityEvent OnCollectAll;
    // Start is called before the first frame update

    private void Awake() {
        instance = this;

    }

    void Start()
    {
        tmp.SetText($"LEARNING MODULES FOUND: {learningModuleCollected} out of {maxlearningModule}");
    }

    public void AddCollected() {
        learningModuleCollected++;
        tmp.SetText($"LEARNING MODULES FOUND: {learningModuleCollected} out of {maxlearningModule}");
        UpgradeManager.instance.upgradePoints++;
        UpgradeManager.instance.CheckUpgradePoints();
        CheckModules();
    }
    public void CheckModules() {
        if(learningModuleCollected >= maxlearningModule) {
            OnCollectAll?.Invoke();
        }
    }
}
