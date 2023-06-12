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

    InteractManager interactManager;

    private void Awake() {
        interactManager = GetComponent<InteractManager>();
    }

    private void Start() {
        if (PlayerPrefs.GetInt(key.name) == 1) {
            Unlock();
            
        }
    }

    public void Unlock() {
        Locked = false;
        interactManager.interactable = false;
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
