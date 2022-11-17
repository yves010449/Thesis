using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DialogueEditor;
public class DialogueManager : MonoBehaviour
{

    public NPCConversation[] Conversation;

    [SerializeField]
    int conversationIndex = 0;

    public int ConversationIndex { get => conversationIndex; set => conversationIndex = value; }

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
       
    }


    public  void StartConversation() {
        ConversationManager.Instance.StartConversation(Conversation[ConversationIndex]);
    }

    public void StartConversation(int conversation) {
        ConversationManager.Instance.StartConversation(Conversation[conversation]);
    }

}
