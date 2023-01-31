using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    [SerializeField]
    GameObject minimap;

    bool isActive;

    public void ToggleMinimap() {
        isActive = !isActive;
        minimap.SetActive(isActive);
        if (isActive) {
            PlayerInput.instance.CanMove = false;
        }
        else {
            PlayerInput.instance.CanMove = true;
        }
    }
}
