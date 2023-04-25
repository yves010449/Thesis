using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField]
    GameObject Map;
    

    private void Start() {
        if (PlayerPrefs.GetInt(gameObject.name) == 1) {
            Map.SetActive(true);
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    public void ActivateMap() {
        PlayerPrefs.SetInt(gameObject.name, 1);
    }
}
