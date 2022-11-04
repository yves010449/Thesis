using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TriggerDialogue : MonoBehaviour {
    [SerializeField]
    int TargetConversationIndex;

   
    public bool unlock;

    InteractDialogue interactTalk;
    private void Awake() {
        interactTalk = GetComponentInParent<InteractDialogue>();
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (!unlock)
            ConversationManager.Instance.StartConversation(interactTalk.Conversation[TargetConversationIndex]);
        else {
            gameObject.SetActive(false);
        }
    }
}
