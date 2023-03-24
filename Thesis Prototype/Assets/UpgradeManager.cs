using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager instance;

    [SerializeField]
    TextMeshProUGUI tmp;

    [SerializeField]
    Button[] buttons;

    [SerializeField]
    Movement movement;
    [SerializeField]
    Transform fov;

    public int upgradePoints = 0;

    [SerializeField]
    float OxygenIncreaseAmount = 0;
    [SerializeField]
    float MovementIncreaseAmount = 0.2f;
    [SerializeField]
    float FovIncreaseAmount = 0.1f;


    private void Awake() {
        instance = this;
    }

    void Start() {
        upgradePoints = PlayerPrefs.GetInt("upgradePoints");
        CheckUpgradePoints();
        if (PlayerPrefs.HasKey("MaxOxygen")) {
            OxygenManager.instance.slider.maxValue = PlayerPrefs.GetFloat("MaxOxygen");
        }
        if (PlayerPrefs.HasKey("MovementSpeed")) {
            movement.MovementSpeed = PlayerPrefs.GetFloat("MovementSpeed");
        }
        if (PlayerPrefs.HasKey("FovScale")) {
            fov.localScale = new Vector3(PlayerPrefs.GetFloat("FovScale"), PlayerPrefs.GetFloat("FovScale"), 0);
        }
    }
    public void CheckUpgradePoints() {
        tmp.SetText($"AVAILABLE UPGRADE POINTS: {upgradePoints}");
        if (upgradePoints == 0) {
            for(int i = 0; i < buttons.Length; i++) {
                buttons[i].interactable = false;
            }
        }
        else {
            for (int i = 0; i < buttons.Length; i++) {
                buttons[i].interactable = true;
            }
        }
        PlayerPrefs.SetInt("upgradePoints", upgradePoints);
    }

    public void IncreaseMaxOxygen() {
        upgradePoints--;
        CheckUpgradePoints();
        OxygenManager.instance.IncreaseMaxOxygen(OxygenIncreaseAmount);
        PlayerPrefs.SetFloat("MaxOxygen", OxygenManager.instance.slider.maxValue);
    }
    public void IncreaseMovementSpeed() {
        upgradePoints--;
        CheckUpgradePoints();
        movement.MovementSpeed += MovementIncreaseAmount;
        PlayerPrefs.SetFloat("MovementSpeed", movement.MovementSpeed);
    }
    public void IncreaseFOV() {
        upgradePoints--;
        CheckUpgradePoints();
        fov.localScale = new Vector3(fov.localScale.x + FovIncreaseAmount, fov.localScale.y + FovIncreaseAmount, 0);
        PlayerPrefs.SetFloat("FovScale", fov.localScale.x);
    }
}
