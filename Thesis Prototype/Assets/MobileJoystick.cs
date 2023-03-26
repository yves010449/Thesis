using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileJoystick : MonoBehaviour
{
    public static MobileJoystick instance;

    
    public MobileInput mobileInput;


    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if(mobileInput.enabled == false) {
            gameObject.SetActive(false);
        }
    }

}
