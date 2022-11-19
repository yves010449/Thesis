using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowImageManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> screens = new List<GameObject>();

    public void DisplayImage(GameObject obj) {
        DisableAll();
        obj.SetActive(true);
    }

    public void DisableAll() {
        for (var i = 0; i < screens.Count; i++) {
            screens[i].SetActive(false);
        }
    }
}
