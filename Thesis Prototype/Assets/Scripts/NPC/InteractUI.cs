using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractUI : MonoBehaviour {
    [SerializeField]
    GameObject PanelUI;

    bool active = false;

    public bool Active { get => active; set => active = value; }

    private void Start() {
        StartCoroutine(ShowUI());
    }

    IEnumerator ShowUI() {
        while (true) {
            if (Active && !PanelUI.activeInHierarchy) {
                PanelUI.SetActive(true);
            }
            if (!Active && PanelUI.activeInHierarchy) {
                PanelUI.SetActive(false);
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}
