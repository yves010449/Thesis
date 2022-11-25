using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class OxygenManager : MonoBehaviour
{

    [SerializeField]
    Slider slider;

    public UnityEvent OnDeath;
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine("DepleteOxygen");
    }

IEnumerator DepleteOxygen() {
        while (true) {
            slider.value -= 1;

            if(slider.value <= 0) {
                OnDeath?.Invoke();
                break;
            }
            yield return new WaitForSeconds(1f);
        }
        
    }
}
