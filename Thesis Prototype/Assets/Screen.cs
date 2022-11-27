using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    public static int width;
    [SerializeField]
    Transform Active;
    [SerializeField]
    Transform Inactive;

    private void OnDisable() {
        gameObject.transform.SetParent(Inactive,false);
    }
}
