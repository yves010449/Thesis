using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPatrol : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer SR;

    float lastX;
    [SerializeField]
    bool RandomPath;

    [SerializeField]
    float movementSpeed;

    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    int targetIndex = 0;

    bool reverse;

    private void Awake() {
        SR = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (RandomPath) {
            MoveRandom();
        }
        else {
            MoveOrder();
        }


        if(lastX < transform.position.x) {
            SR.flipX = false;
        }
        else {
            SR.flipX = true;
        }

        
    }
    public void MoveOrder() {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[targetIndex].position, movementSpeed * Time.fixedDeltaTime);
        if (Vector2.Distance(transform.position, waypoints[targetIndex].position) < 0.2f) {
            if (!reverse) {
                targetIndex++;
                if (targetIndex >= waypoints.Length) {
                    targetIndex--;
                    reverse = true;
                }
            }
            else {
                targetIndex--;
                if (targetIndex < 0) {
                    targetIndex++;
                    reverse = false;
                }
            }
        }
    }
    public void MoveRandom() {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[targetIndex].position, movementSpeed * Time.fixedDeltaTime);
        if (Vector2.Distance(transform.position, waypoints[targetIndex].position) < 0.2f) {
            targetIndex = Random.Range(0, waypoints.Length);
        }
    }

    private void LateUpdate() {
        lastX = transform.position.x;
    }
}
