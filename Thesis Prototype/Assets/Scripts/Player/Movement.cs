using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Movement : MonoBehaviour
{

    public float MovementSpeed;
    Rigidbody2D rb;
    Vector2 input;

    public Vector2 Input { get => input; set => input = value; }

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ConversationManager.Instance.IsConversationActive || !PlayerController.instance.CanMove) {
            rb.velocity = Vector2.zero;
            return;
        }
        rb.velocity = Input * MovementSpeed * Time.fixedDeltaTime;
    }
}
