using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [SerializeField]
    DataManager[] datas;

    public void DeleteData() {
        foreach (DataManager data in datas) {
            data.RemoveData();
        }
        PlayerData.instance.saveData = false;
        PlayerPrefs.DeleteKey("playerX");
        PlayerPrefs.DeleteKey("playerY");
        PlayerPrefs.DeleteKey("Oxygen");
        PlayerPrefs.DeleteKey("FovSize");
    }
}
