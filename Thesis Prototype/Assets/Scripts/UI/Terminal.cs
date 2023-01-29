using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : MonoBehaviour
{
    public static Terminal instance;

    private void Start() {
        gameObject.SetActive(false);
    }
    private void Awake() {
        instance = this;
    }

}
