using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance;

    [HideInInspector]
    public bool saveData = true;

    private void Awake() {
        instance = this;
    }


    void Start()
    {
        if (PlayerPrefs.HasKey("playerX") && PlayerPrefs.HasKey("playerY")) {
            transform.position = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
            OxygenManager.instance.slider.value = PlayerPrefs.GetFloat("Oxygen");
            OxygenManager.instance.size = PlayerPrefs.GetFloat("FovSize");
        }
        //StartCoroutine(Save());
    }

    private void Update() {
        PlayerPrefs.SetFloat("playerX", transform.position.x);
        PlayerPrefs.SetFloat("playerY", transform.position.y);
        PlayerPrefs.SetFloat("Oxygen", OxygenManager.instance.slider.value);
        PlayerPrefs.SetFloat("FovSize", OxygenManager.instance.size);
    }

    //IEnumerator Save() {
    //    while (saveData) {
    //        PlayerPrefs.SetFloat("playerX", transform.position.x);
    //        PlayerPrefs.SetFloat("playerY", transform.position.y);
    //        PlayerPrefs.SetFloat("Oxygen", OxygenManager.instance.slider.value);
    //        PlayerPrefs.SetFloat("FovSize", OxygenManager.instance.size);
    //        yield return new WaitForSeconds(0.1f);
    //    }
    //}




}
