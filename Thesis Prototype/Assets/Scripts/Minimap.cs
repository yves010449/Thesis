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
            PlayerController.instance.CanMove = false;
        }
        else {
            PlayerController.instance.CanMove = true;
        }
    }
}
