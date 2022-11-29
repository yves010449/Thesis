using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : InteractionDetectors
{
    public override void Detect() {
        //colliders.
    }

    public void Interact() { 
        if (colliders.Length > 0) {
            if (colliders[0].TryGetComponent(out Interactions interactions)) {
                interactions.Interact();
            }
            //colliders[0].GetComponent<Interactions>().Interact();
        }
    }
}
