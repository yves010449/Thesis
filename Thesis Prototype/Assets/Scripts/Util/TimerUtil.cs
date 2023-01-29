using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerUtil : MonoBehaviour
{
    public UnityEvent OnTimer;
    // Start is called before the first frame update
    public void StartTimer(float time)
    {
        StartCoroutine(Counter(time));
    }

    IEnumerator Counter(float time) {
        yield return new WaitForSeconds(time);
        OnTimer?.Invoke();
    }

}
