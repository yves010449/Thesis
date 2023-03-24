using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class QuestionHolder : MonoBehaviour {
    [SerializeField]
    ChlorobotQuestionManager QuestionManager;
    [SerializeField]
    NPCConversation[] conversations;


    private void Start() {
        if (PlayerPrefs.GetInt(gameObject.name) == 1) {
            AddQuestions();
        }
    }

    public void AddQuestions() {
        for (int i = 0; i < conversations.Length; i++) {
            QuestionManager.ActiveConversations.Add(conversations[i]);
        }
    }
}
