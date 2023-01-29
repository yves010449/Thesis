using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent OnTrigger;
    public UnityEvent OffTrigger;

    private void OnTriggerEnter2D(Collider2D collision) {
        OnTrigger?.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision) {
        OffTrigger?.Invoke();
    }


}
