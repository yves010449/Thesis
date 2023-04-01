using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using TMPro;
using UnityEngine.UI;

public class ChlorobotQuestionManager : MonoBehaviour
{
    public static ChlorobotQuestionManager instance;

    public List<NPCConversation> ActiveConversations = new List<NPCConversation>();

    public List<NPCConversation> InactiveConversations = new List<NPCConversation>();

    [SerializeField]
    bool randomized;
    [SerializeField]
    TextMeshProUGUI ScreenText;

    [SerializeField]
    NPCConversation NoQuestionDialogue;

    [SerializeField]
    ScrollRect scrollRect;

    private void Awake() {
        instance = this;
    }

    private void OnEnable() {
        ConversationManager.OnConversationStarted += ConversationStart;
        ConversationManager.OnConversationEnded += ConversationEnd;
    }

    private void OnDisable() {
        ConversationManager.OnConversationStarted -= ConversationStart;
        ConversationManager.OnConversationEnded -= ConversationEnd;
       
    }

    private void ConversationStart() {
    }

    private void ConversationEnd() {
        if (GameObject.FindGameObjectWithTag("RobotUI") != null) {
           
            GameObject.FindGameObjectWithTag("RobotUI").SetActive(false);
            //ScreenText.SetText("");
        }
    }

    public void StartConversation() {
        int index = 0;
        if (ActiveConversations.Count == 0 && InactiveConversations.Count == 0) {
            ConversationManager.Instance.StartConversation(NoQuestionDialogue);
        }
        else if (ActiveConversations.Count > 0) {
            if (randomized) {
                index = Random.Range(0, ActiveConversations.Count - 1);
            }
            ConversationManager.Instance.StartConversation(ActiveConversations[index]);
            InactiveConversations.Add(ActiveConversations[index]);
            ActiveConversations.Remove(ActiveConversations[index]);
            if (ActiveConversations.Count == 0) {
                ActiveConversations = InactiveConversations;
            }
            
        }
    }
        

    public void StartConversation(int conversation) {
        ConversationManager.Instance.StartConversation(ActiveConversations[conversation]);
    }

    public void SetText(CodeText code) {
        ScreenText.SetText(code.Code);
        scrollRect.verticalNormalizedPosition = 1;
    }


}
