using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    KeyController key;

    public bool Locked;

    private void Start() {
        if (PlayerPrefs.GetInt(key.name) == 1) {
            Unlock();
        }
    }

    public void Unlock() {
        Locked = false;
    }
    public void Lock() {
        Locked = true;
    }

    public void Open() {
        if (!Locked) {
            animator.SetBool("isOpen", true);
        }
        
    }

    public void Close() {
        if (!Locked) {
            animator.SetBool("isOpen", false);
        }
    }

    
}
