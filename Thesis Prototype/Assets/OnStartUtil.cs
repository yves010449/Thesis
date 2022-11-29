using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class OnStartUtil : MonoBehaviour
{
    public UnityEvent OnEnableScreen;

    private void Start() {
        OnEnableScreen?.Invoke();
    }
}
