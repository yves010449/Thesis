using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.Events;

public class CollisionTrigger : MonoBehaviour {

    public UnityEvent OnTrigger;

    private void OnCollisionEnter2D(Collision2D collision) {
        OnTrigger?.Invoke();     
    }
}
