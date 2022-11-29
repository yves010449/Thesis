using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class QuestionManager : MonoBehaviour
{
    public NPCConversation[] Conversation;

    public void StartRandomQuestion() {
        ConversationManager.Instance.EndConversation();
        ConversationManager.Instance.StartConversation(Conversation[Random.Range(0,Conversation.Length)]);
        Debug.Log(Random.Range(0, Conversation.Length));
    }

    public void StartQuestion(NPCConversation conversation) {
        ConversationManager.Instance.EndConversation();
        ConversationManager.Instance.StartConversation(conversation);
    }
}
