using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsManager : MonoBehaviour {
    public static AchievementsManager instance;

    [SerializeField]
    Animator animator;
    [SerializeField]
    TextMeshProUGUI tmpText;
    [SerializeField]
    Image image;

    [SerializeField]
    List<AchievementData> LearningModuleCollectAchievement = new List<AchievementData>();
    [SerializeField]
    List<AchievementData> DeathAchievement = new List<AchievementData>();
    [SerializeField]
    List<AchievementData> ConversationAchievement = new List<AchievementData>();
    [SerializeField]
    List<AchievementData> CorrectAnswerAchievement = new List<AchievementData>();

    private void Awake() {
        instance = this;
    }

    IEnumerator Start() {
        while (true) {
            foreach (AchievementData achievementData in LearningModuleCollectAchievement) {
                if (LearningModuleManager.instance.learningModuleCollected == achievementData.requirement && !achievementData.activated) {
                    tmpText.SetText(achievementData.text);
                    image.sprite = achievementData.sprite;
                    animator.SetTrigger("Activate");
                    achievementData.Activate();
                }
            }
            foreach (AchievementData achievementData in DeathAchievement) {
                if (LearningModuleManager.instance.totalDeaths == achievementData.requirement && !achievementData.activated) {
                    tmpText.SetText(achievementData.text);
                    image.sprite = achievementData.sprite;
                    animator.SetTrigger("Activate");
                    achievementData.Activate();
                }
            }
            //foreach (AchievementData achievementData in ConversationAchievement) {
            //    if (LearningModuleManager.instance.totalQuestions == achievementData.requirement && !achievementData.activated) {
            //        tmpText.SetText(achievementData.text);
            //        image.sprite = achievementData.sprite;
            //        animator.SetTrigger("Activate");
            //        achievementData.Activate();
            //    }
            //}
            foreach (AchievementData achievementData in CorrectAnswerAchievement) {
                if (LearningModuleManager.instance.totalCorrectAnswers == achievementData.requirement && !achievementData.activated) {
                    tmpText.SetText(achievementData.text);
                    image.sprite = achievementData.sprite;
                    animator.SetTrigger("Activate");
                    achievementData.Activate();
                }
            }
            yield return new WaitForSeconds(1f);
        }
        
    }




}
