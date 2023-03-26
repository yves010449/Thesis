using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour {

    [SerializeField]
    float range = 2;


    public void Interact(Collider2D collider) {

        float distance = Vector3.Distance(transform.position, collider.transform.position);
        if (collider != null && PlayerController.instance.CanMove && distance<=range) {
            if (collider.TryGetComponent(out Interactions interactions)) {
                interactions.Interact();
            }
        }
    }
    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
