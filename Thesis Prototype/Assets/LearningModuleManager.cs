using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class LearningModuleManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI tmp;
    int learningModuleCollected = 0;
    [SerializeField]
    int maxlearningModule = 1;

    public UnityEvent OnCollectAll;
    // Start is called before the first frame update
    void Start()
    {
        tmp.SetText($"LEARNING MODULES FOUND: {learningModuleCollected} out of {maxlearningModule}");
    }

    public void AddCollected() {
        learningModuleCollected++;
        tmp.SetText($"LEARNING MODULES FOUND: {learningModuleCollected} out of {maxlearningModule}");
        CheckModules();
    }
    public void CheckModules() {
        if(learningModuleCollected >= maxlearningModule) {
            OnCollectAll?.Invoke();
        }
    }
}
