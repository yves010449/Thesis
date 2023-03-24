using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("playerX") && PlayerPrefs.HasKey("playerY")) {
            transform.position = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
            OxygenManager.instance.slider.value = PlayerPrefs.GetFloat("Oxygen");
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("playerX", transform.position.x);
        PlayerPrefs.SetFloat("playerY", transform.position.y);
        PlayerPrefs.SetFloat("Oxygen", OxygenManager.instance.slider.value);
    }
}
