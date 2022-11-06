using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DialogueEditor;
public class InteractDialogue : Interactions
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


    public override void Interact() {
        ConversationManager.Instance.StartConversation(Conversation[ConversationIndex]);
    }

}
