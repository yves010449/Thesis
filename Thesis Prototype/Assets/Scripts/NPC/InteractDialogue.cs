using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DialogueEditor;
public class InteractDialogue : Interactions
{

    public NPCConversation[] Conversation;
    [SerializeField]
    int ConversationIndex = 0;

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
        if(ConversationIndex < Conversation.Length-1) {
            ConversationIndex++;
        }
    }


    public override void Interact() {
        if(ConversationIndex >= Conversation.Length) {
            return;
        }
        ConversationManager.Instance.StartConversation(Conversation[ConversationIndex]);
    }

}
