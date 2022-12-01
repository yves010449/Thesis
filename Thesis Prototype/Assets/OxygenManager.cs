using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DialogueEditor;
public class OxygenManager : MonoBehaviour {

    [SerializeField]
    Slider slider;
    [SerializeField]
    Image img;

    public UnityEvent OnDeath;

    bool isDepleting = true;

    public bool IsDepleting { get => isDepleting; set => isDepleting = value; }

    // Start is called before the first frame update
    private void Start() {
        StartCorotine();
    }
    public void StartCorotine() {
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
            if(slider.value <= slider.maxValue * 0.35f) {
                img.transform.gameObject.SetActive(true);
                yield return new WaitForSeconds(2f);
            }
            else {
                img.transform.gameObject.SetActive(false);
                yield return new WaitForSeconds(1f);
            }
                
        }

    }

}
