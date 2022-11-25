using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    Animator animator;

    public bool isUnlocked;

    public void Open() {
        animator.SetBool("isUnlocked", isUnlocked);
        if(animator.GetBool("isUnlocked"))
            animator.SetTrigger("Open");
    }

    public void Close() {
        animator.SetBool("isUnlocked", isUnlocked);
        if (animator.GetBool("isUnlocked"))
            animator.SetTrigger("Close");
    }
}
