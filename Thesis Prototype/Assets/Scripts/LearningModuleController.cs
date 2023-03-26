using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningModuleController : MonoBehaviour
{
    [SerializeField]
    QuestionHolder question;

    void Start() {
        if (PlayerPrefs.GetInt(gameObject.name) == 1) {
            gameObject.SetActive(false);
        }

    }


    public  void Collected() {
        PlayerPrefs.SetInt(gameObject.name, 1);
        LearningModuleManager.instance.ActivateModule();
        LearningModuleManager.instance.AddCollected();
        question.AddQuestions();
        gameObject.SetActive(false);
    }
}
