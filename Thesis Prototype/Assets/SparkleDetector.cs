using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkleDetector : MonoBehaviour
{

    [SerializeField]
    LayerMask Layer;
    [SerializeField]
    GameObject GFX;

    float radius;

    [HideInInspector]
    public Collider2D[] colliders;

    private void Start() {
        radius =  GetComponent<CircleCollider2D>().radius;
    }

    void Update() {
       
        colliders = Physics2D.OverlapCircleAll(transform.position, radius, Layer);
        if (colliders.Length > 0) {
            GFX.SetActive(true);
        }
    }




}
