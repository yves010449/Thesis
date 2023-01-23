using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    NPCConversation conversation;
    public bool isUnlocked;

    public void Unlock() {
        isUnlocked = true;
    }
    public void Lock() {
        isUnlocked = false;
    }

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

    public void DoorIsLocked() {
        if (!isUnlocked) {
            ConversationManager.Instance.StartConversation(conversation);
        }
    }
}
