using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnDisableUtil : MonoBehaviour
{
    public UnityEvent OnEnableScreen;

    private void OnDisable() {
        OnEnableScreen?.Invoke();
    }
}
