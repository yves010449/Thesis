using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.Events;

public class TriggerDialogue : MonoBehaviour {
    [SerializeField]
    NPCConversation conversation;

    public UnityEvent OnTrigger;

    private void OnCollisionEnter2D(Collision2D collision) {
         ConversationManager.Instance.StartConversation(conversation);
        OnTrigger?.Invoke();
        gameObject.SetActive(false);
    }
}
