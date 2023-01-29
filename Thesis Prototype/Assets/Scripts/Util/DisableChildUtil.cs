using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableChildUtil : MonoBehaviour
{
    public void DisableChild() {
        foreach (Transform child in transform)
            child.gameObject.SetActive(false);
    }

    private void OnDisable() {
        DisableChild();
    }
}
