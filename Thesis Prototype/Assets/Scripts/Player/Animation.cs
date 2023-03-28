using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class Animation : MonoBehaviour
{
    Animator animator;
    SpriteRenderer rd;

    Vector2 input;
    bool isDead;

    public Vector2 Input { get => input; set => input = value; }

    Vector2 lastDir;
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
            animator.SetFloat("inputX", input.x);
            animator.SetFloat("inputY", input.y);
        }
        else {
            animator.SetBool("isMoving", false);
            animator.SetFloat("lastX", lastDir.x);
            animator.SetFloat("lastY", lastDir.y);
        }

        

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

    private void LateUpdate() {
        if(input.x != 0 || input.y != 0) {
            lastDir.x = input.x;
            lastDir.y = input.y;
        }
    }

    public void IsDead() {
        animator.SetTrigger("isDead");
    }
    public void Respawn() {
        animator.SetTrigger("respawn");
    }
}
