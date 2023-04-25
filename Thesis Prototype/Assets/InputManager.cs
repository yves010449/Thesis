using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    PCInput Pc;
    [SerializeField]
    MobileInput mobileInput;

    [SerializeField]
    bool isMobile = false;
    // Start is called before the first frame update
    void Start()
    {
        if (isMobile) {
            mobileInput.enabled = true;
            Pc.enabled = false;
        }
        else {
            mobileInput.enabled = false;
            Pc.enabled = true;
        }
    }

}
