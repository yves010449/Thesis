using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using TMPro;

public class ChlorobotQuestionManager : MonoBehaviour
{
    public static ChlorobotQuestionManager instance;

    public List<NPCConversation> ActiveConversations = new List<NPCConversation>();

    public List<NPCConversation> InactiveConversations = new List<NPCConversation>();

    [SerializeField]
    TextMeshProUGUI ScreenText;

    [SerializeField]
    NPCConversation NoQuestionDialogue;

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
    int index = 0;

    public void StartConversation() {
        if (ActiveConversations.Count == 0 && InactiveConversations.Count == 0) {
            ConversationManager.Instance.StartConversation(NoQuestionDialogue);
        }

        else if (ActiveConversations.Count > 0) {

            //int index = Random.Range(0, ActiveConversations.Count-1);
            
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
        //GetComponent<ScrollRect>().verticalNormalizedPosition = 0;
    }


}
