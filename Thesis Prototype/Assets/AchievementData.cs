using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchievementData : MonoBehaviour
{
    [SerializeField]
    Image image;

    public Sprite sprite;
    public string text;

    public int requirement;
    public bool activated = false;

    TextMeshProUGUI tmpText;

    private void Awake() {
        //image = GetComponentInChildren<Image>();
        tmpText = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void OnEnable() {
        tmpText.SetText(text);
        image.sprite = sprite;
        if (PlayerPrefs.GetInt(gameObject.name) == 1) {
            image.color = new Color(255, 255, 255, 1f);
            activated = true;
        }
        else {
            image.color = new Color(0, 0, 0, 1f);
        }
    }

    public void Activate() {
        PlayerPrefs.SetInt(gameObject.name, 1);
        activated = true;
    }
}
