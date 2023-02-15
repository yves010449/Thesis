using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DialogueEditor;

public class PlayerInput : MonoBehaviour {

    public static PlayerInput instance;
    public UnityEvent<Vector2> OnMovement;
    public UnityEvent OnInteract, OnMap, OnLearningTerminal;
    Vector2 input;
    bool canMove = true;


    public bool CanMove { get => canMove; set => canMove = value; }

    private void Awake() {
        instance = this;

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {
            GameManager.instance.PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.M) && !GameManager.instance.isPaused) {
            OnMap?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Tab) && !GameManager.instance.isPaused) {
            OnLearningTerminal?.Invoke();
        }


        if (ConversationManager.Instance.IsConversationActive || !CanMove) {
            OnMovement?.Invoke(new Vector2(0, 0));
            return;
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            OnInteract?.Invoke();
        }

        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        input.Normalize();
        OnMovement?.Invoke(input);
    }
}
