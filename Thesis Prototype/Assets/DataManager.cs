using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{


    public void RemoveData() {
        foreach (Transform child in transform) {
            PlayerPrefs.DeleteKey(child.name);
        }
            
    }
}
