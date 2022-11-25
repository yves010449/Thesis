using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DialogueEditor;

public class PlayerInput : MonoBehaviour {


    public UnityEvent<Vector2> OnMovement;
    public UnityEvent OnInteract;
    Vector2 input;
    bool isDead;

    public bool IsDead { get => isDead; set => isDead = value; }

    void Update()
    {
        if (ConversationManager.Instance.IsConversationActive || GameManager.instance.terminal.activeInHierarchy || isDead) {
            OnMovement?.Invoke(new Vector2(0,0));
            return;
        }

        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        input.Normalize();
        OnMovement?.Invoke(input);

        if (Input.GetKeyDown(KeyCode.E)) {
            OnInteract?.Invoke();
        }
        
    }
}
