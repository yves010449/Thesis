using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUtil : MonoBehaviour
{
    [SerializeField]
    Transform Target;

    [SerializeField]
    Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Target.position + offset;
    }
}
