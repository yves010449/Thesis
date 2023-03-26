using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DialogueEditor;
public class InteractManager : Interactions {


    public UnityEvent OnInteract;
    


    public override void Interact() {
            OnInteract?.Invoke();
    }

}
