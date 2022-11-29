using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DialogueEditor;
public class OxygenManager : MonoBehaviour {

    [SerializeField]
    Slider slider;

    public UnityEvent OnDeath;

    bool isDepleting = true;

    public bool IsDepleting { get => isDepleting; set => isDepleting = value; }

    // Start is called before the first frame update
    private void Start() {
        StartCoroutine("DepleteOxygen");     
    }
    public void StartDepleteOxygen() {
        isDepleting = true;
        slider.gameObject.SetActive(true);
    }
    public void StopDepleteOxygen() {
        isDepleting = false;
        slider.gameObject.SetActive(false);
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
            if (isDepleting && !ConversationManager.Instance.IsConversationActive) {
                slider.value -= 1;
            }
            if (slider.value <= 0) {
                OnDeath?.Invoke();
                break;
            }
            yield return new WaitForSeconds(1f);
        }

    }

}
