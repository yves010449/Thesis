using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReavelRoom : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision) {
        if (gameObject.transform.GetChild(0).gameObject.activeInHierarchy)
            return;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision) {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
}
