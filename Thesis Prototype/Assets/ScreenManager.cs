using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public GameObject[] screens;


    public void DisplayPanel(GameObject gameObj) {
        DisableChild();
        gameObj.SetActive(true);
    }

    public void DisableChild() {
        foreach (GameObject screen in screens)
            screen.gameObject.SetActive(false);
    }

    private void OnDisable() {
        DisableChild();
    }
}
