using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class Animation : MonoBehaviour
{
    Animator animator;
    SpriteRenderer rd;

    Vector2 input;

    public Vector2 Input { get => input; set => input = value; }

    private void Awake() {
        animator = GetComponent<Animator>();
        rd = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ConversationManager.Instance.IsConversationActive) {
            animator.SetBool("isMoving", false);
            return;
        }

        if (input.x != 0 || input.y != 0) {
            animator.SetBool("isMoving", true); 
        }
        else {
            animator.SetBool("isMoving", false);
        }

        animator.SetFloat("inputX", input.x);
        animator.SetFloat("inputY", input.y);

        Flip();
    }

    private void Flip() {
        if (input.x < 0) {
            rd.flipX = true;
        }
        if (input.x > 0) {
            rd.flipX = false;
        }
    }
}
