using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAnimator : MonoBehaviour
{
    Animator animator;

    SpriteRenderer SR;

    private Vector2 input;

    public Vector2 Input { get => input; set => input = value; }

    private void Awake() {
        SR = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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
            SR.flipX = true;
        }
        if (input.x > 0) {
            SR.flipX = false;
        }
    }


}
