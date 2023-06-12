using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchievementData : MonoBehaviour
{
    [SerializeField]
    Image image;
    [SerializeField]
    TextMeshProUGUI tmpTitle;
    [SerializeField]
    TextMeshProUGUI tmpDesc;


    public AchievementsSO achievementsSO;

    public int requirement;
    public bool activated = false;







    private void OnEnable() {
        tmpTitle.SetText(achievementsSO.title);
        tmpDesc.SetText(achievementsSO.description);

        image.sprite = achievementsSO.sprite;
        if (PlayerPrefs.GetInt(achievementsSO.name) == 1) {
            image.color = new Color(255, 255, 255, 1f);
            activated = true;
        }
        else {
            image.color = new Color(0, 0, 0, 1f);
        }
    }

    public void Activate() {
        PlayerPrefs.SetInt(achievementsSO.name, 1);
        activated = true;
    }
}
