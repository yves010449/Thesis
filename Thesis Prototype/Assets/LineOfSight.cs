using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{
    [SerializeField]
    OxygenManager oxygenManager;
    [Range(0.10f,1)][SerializeField]
    float cap = 0.35f;

    private void Start() {
        StartCoroutine(StartCoroutine());
    }


    IEnumerator StartCoroutine()
    {
        float size = (oxygenManager.slider.value / oxygenManager.slider.maxValue);
        if(size > cap) {
            transform.localScale = new Vector2(size, size);
        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(StartCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
