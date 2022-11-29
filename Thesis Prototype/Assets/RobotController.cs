using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    ChangeScreen changeScreen;

    public void Idle() {
        animator.SetTrigger("Idle");
        changeScreen.SetDefaultParent();
    }
    public void Blank(Transform obj) {
        animator.SetTrigger("Blank");
        changeScreen.SetScreenParent(obj);
    }
    public void BlankDebug() {
        animator.SetTrigger("Blank");
        changeScreen.SetDefaultParent();
    }
}
