using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class OxygenManager : MonoBehaviour {

    [SerializeField]
    Slider slider;

    public UnityEvent OnDeath;
    // Start is called before the first frame update
    void OnEnable() {
        StartDepleteOxygen();
    }
    public void StartDepleteOxygen() {
        StartCoroutine("DepleteOxygen");
    }

    public void AddOxygen(int amount) {
        slider.value += amount;
    }
    public void ReduceOxygen(int amount) {
        slider.value -= amount;
    }
    public void RefillOxygen() {
        slider.value = slider.maxValue;
    }

    IEnumerator DepleteOxygen() {
        while (true) {
            slider.value -= 1;

            if (slider.value <= 0) {
                OnDeath?.Invoke();
                break;
            }
            yield return new WaitForSeconds(1f);
        }

    }

}
