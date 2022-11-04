using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : InteractionDetectors
{
    public override void Detect() {
        
    }

    public void Interact() {
        if (colliders.Length > 0) {
            colliders[0].GetComponentInParent<Interactions>().Interact();
        }
    }
}
