using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugQuizManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI ScreenText;

    [SerializeField]
    TMP_InputField InputField;

    string ActiveQuestion;
    string ActiveCorrectAnswer;


    public void Quiz(DebugQuiz quiz) {
        ActiveQuestion = quiz.Question;
        ActiveCorrectAnswer = quiz.CorrectAnswer;
        ScreenText.SetText(ActiveQuestion);
    }

    public void CheckQuiz() {
        if(ActiveCorrectAnswer == InputField.text.ToString()) {
            Debug.Log("correct");
        }
        else {
            Debug.Log("incorrect");
        }
    }
}
