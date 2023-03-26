using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DialogueEditor;

public class PlayerController : MonoBehaviour {


    public static PlayerController instance;
    public UnityEvent<Vector2> OnMovement;
    public UnityEvent  OnMap, OnLearningTerminal;
    public UnityEvent<Collider2D> OnInteract;
    bool canMove = true;


    public bool CanMove { get => canMove; set => canMove = value; }

    private void Awake() {
        instance = this;

    }

    void Update() {

        if (ConversationManager.Instance.IsConversationActive || !CanMove) {
            OnMovement?.Invoke(new Vector2(0, 0));
            return;
        }
    }


    public void Pause() {
        if (!ConversationManager.Instance.IsConversationActive)
            GameManager.instance.PauseGame();
    }
    public void LearningTerminal() {
        if (!GameManager.instance.isPaused)
            OnLearningTerminal?.Invoke();
    }
    public void Interact(Collider2D collider) {
        if (!GameManager.instance.isPaused)
            OnInteract?.Invoke(collider);
    }
}

