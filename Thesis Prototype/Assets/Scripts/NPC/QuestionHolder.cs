using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class QuestionHolder : MonoBehaviour {
    [SerializeField]
    QuestionManager QuestionManager;
    [SerializeField]
    NPCConversation[] conversations;
    

    public void AddQuestions() {
        for (int i = 0; i < conversations.Length; i++) {
            QuestionManager.Conversations.Add(conversations[i]);
        }
    }
}
