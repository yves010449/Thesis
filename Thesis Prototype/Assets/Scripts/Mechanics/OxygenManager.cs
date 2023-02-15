using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DialogueEditor;
public class OxygenManager : MonoBehaviour {

    public static OxygenManager instance;

    public Slider slider;
    [SerializeField]
    Image img;
    [SerializeField]
    float depleteRate = 1f;
    public UnityEvent OnDeath;

    bool isDepleting = true;

    public bool IsDepleting { get => isDepleting; set => isDepleting = value; }

    private void Awake() {
        instance = this;
    }

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
    public void AddOxygen() {
        slider.value += 5;
    }

    public void ReduceOxygen(int amount) {
        slider.value -= amount;
    }
    public void RefillOxygen() {
        slider.value = slider.maxValue;
    }
    public void IncreaseMaxOxygen(float value) {
        slider.maxValue += value;
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
                yield return new WaitForSeconds(depleteRate+1f);
            }
            else {
                img.transform.gameObject.SetActive(false);
                yield return new WaitForSeconds(depleteRate);
            }
                
        }

    }

}
