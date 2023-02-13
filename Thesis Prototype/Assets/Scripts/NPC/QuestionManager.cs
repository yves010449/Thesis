using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class QuestionManager : MonoBehaviour
{
    public NPCConversation[] Conversation;

    int conversationIndex = 0;


    private void OnEnable() {
        ConversationManager.OnConversationStarted += ConversationStart;
        ConversationManager.OnConversationEnded += ConversationEnd;
    }

    private void OnDisable() {
        ConversationManager.OnConversationStarted -= ConversationStart;
        ConversationManager.OnConversationEnded -= ConversationEnd;
    }

    private void ConversationStart() {
    }

    private void ConversationEnd() {
        if (GameObject.FindGameObjectWithTag("RobotUI") != null)
            GameObject.FindGameObjectWithTag("RobotUI").SetActive(false);
    }


    public void StartConversation() {
        if (Conversation != null) {
            ConversationManager.Instance.StartConversation(Conversation[conversationIndex]);
            conversationIndex++;
            if(conversationIndex>= Conversation.Length) {
                conversationIndex = 0;
            }
        }
    }
        

    public void StartConversation(int conversation) {
        ConversationManager.Instance.StartConversation(Conversation[conversation]);
    }


}
