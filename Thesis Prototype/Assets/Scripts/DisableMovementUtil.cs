using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMovementUtil : MonoBehaviour {

    private void OnEnable() {
        OxygenManager.instance.IsDepleting = false;
        PlayerController.instance.CanMove = false;
        
        if (MobileJoystick.instance.mobileInput.enabled == true && MobileJoystick.instance.mobileInput != null) {
            MobileJoystick.instance.gameObject.SetActive(false);
        }
    }
    private void OnDisable() {
        PlayerController.instance.CanMove = true;
        OxygenManager.instance.IsDepleting = true;

        if (MobileJoystick.instance.mobileInput.enabled == true) {
            MobileJoystick.instance.gameObject.SetActive(true);
        }



    }

}
