using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMovementUtil : MonoBehaviour
{

    private void OnEnable() {
        PlayerInput.instance.CanMove = false;
        OxygenManager.instance.IsDepleting = false;
    }
    private void OnDisable() {
        PlayerInput.instance.CanMove = true;
        OxygenManager.instance.IsDepleting = true;
    }
}
