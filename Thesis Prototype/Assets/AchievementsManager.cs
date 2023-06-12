using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AchievementsManager : MonoBehaviour {
    public static AchievementsManager instance;

    [SerializeField]
    TextMeshProUGUI tmpTitle;
    [SerializeField]
    TextMeshProUGUI tmpDesc;
    [SerializeField]
    Image image;

    public UnityEvent OnActivate;

    [SerializeField]
    List<AchievementData> LearningModuleCollectAchievement = new List<AchievementData>();
    [SerializeField]
    List<AchievementData> DeathAchievement = new List<AchievementData>();
    [SerializeField]
    List<AchievementData> CorrectAnswerAchievement = new List<AchievementData>();
    [SerializeField]
    AchievementData OverfillAchievement;
    [SerializeField]
    AchievementData ZeroDeathsAchievement;

    private void Awake() {
        instance = this;
    }

    public void LearningModuleAchievement() {
        foreach (AchievementData achievementData in LearningModuleCollectAchievement) {
            if (LearningModuleManager.instance.learningModuleCollected == achievementData.requirement && !achievementData.activated) {
                tmpTitle.SetText(achievementData.achievementsSO.title);
                tmpDesc.SetText(achievementData.achievementsSO.description);
                image.sprite = achievementData.achievementsSO.sprite;
                ActivateAchievement();
                achievementData.Activate();
            }
        }
    }

    public void CheckCorrectAnswerAchievement() {
        foreach (AchievementData achievementData in CorrectAnswerAchievement) {
            if (LearningModuleManager.instance.totalCorrectAnswers == achievementData.requirement && !achievementData.activated) {
                tmpTitle.SetText(achievementData.achievementsSO.title);
                tmpDesc.SetText(achievementData.achievementsSO.description);
                image.sprite = achievementData.achievementsSO.sprite;
                ActivateAchievement();
                achievementData.Activate();
            }
        }
    }

    public void CheckDeathAchievement() {
        foreach (AchievementData achievementData in DeathAchievement) {
            if (LearningModuleManager.instance.totalDeaths == achievementData.requirement && !achievementData.activated) {

                tmpTitle.SetText(achievementData.achievementsSO.title);
                tmpDesc.SetText(achievementData.achievementsSO.description);
                image.sprite = achievementData.achievementsSO.sprite;
                ActivateAchievement();
                achievementData.Activate();
            }
        }
    }

    public void CheckOverfillAchievement() {
        if (OxygenManager.instance.slider.value >= OxygenManager.instance.slider.maxValue && !OverfillAchievement.activated) {
            tmpTitle.SetText(OverfillAchievement.achievementsSO.title);
            tmpDesc.SetText(OverfillAchievement.achievementsSO.description);
            image.sprite = OverfillAchievement.achievementsSO.sprite;
            ActivateAchievement();
            OverfillAchievement.Activate();
        }
    }

    public void CheckZeroDeathsAchievement() {
        if (LearningModuleManager.instance.totalDeaths == 0 && !OverfillAchievement.activated) {
            tmpTitle.SetText(ZeroDeathsAchievement.achievementsSO.title);
            tmpDesc.SetText(ZeroDeathsAchievement.achievementsSO.description);
            image.sprite = ZeroDeathsAchievement.achievementsSO.sprite;
            ActivateAchievement();
            ZeroDeathsAchievement.Activate();
        }
    }


    public void ActivateAchievement() {
        OnActivate?.Invoke();
    }


}
