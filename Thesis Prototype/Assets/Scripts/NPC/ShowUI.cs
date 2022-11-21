using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class ShowUI : MonoBehaviour {
    [SerializeField]
    GameObject UI;


    private void OnTriggerEnter2D(Collider2D collision) {
        UI.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision) {
        UI.SetActive(false);
    }

}
