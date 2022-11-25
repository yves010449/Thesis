using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScreenEnable : MonoBehaviour
{
    public UnityEvent OnEnableScreen;

    private void OnEnable() {
        OnEnableScreen?.Invoke();
    }
}
