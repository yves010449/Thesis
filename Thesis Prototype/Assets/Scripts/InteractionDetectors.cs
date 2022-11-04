using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractionDetectors : MonoBehaviour {

    [SerializeField]
    bool ShowGizmo;
    [SerializeField]
    LayerMask Layer;

    public float radius;

    [HideInInspector]
    public Collider2D[] colliders;

    private void Start() {
        GetComponent<CircleCollider2D>().radius = radius;
    }

    void Update() {
        colliders = Physics2D.OverlapCircleAll(transform.position, radius, Layer);
        Detect();
    }

    public abstract void Detect();

    private void OnDrawGizmos() {
        if (!ShowGizmo) {
            return;
        }
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);

    }
}
