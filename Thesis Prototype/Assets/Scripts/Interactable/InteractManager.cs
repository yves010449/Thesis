using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DialogueEditor;
public class InteractManager : Interactions {


    public UnityEvent OnInteract;
    
    bool onRange;


    public override void Interact() {
            OnInteract?.Invoke();
    }

    private void OnMouseDown() {
        if (onRange && !ConversationManager.Instance.IsConversationActive && PlayerInput.instance.CanMove) {      
            Interact();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        onRange = true;
    }
    private void OnTriggerExit2D(Collider2D collision) {
        onRange = false;
    }
}
