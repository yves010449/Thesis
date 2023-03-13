using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class QuestionManager : MonoBehaviour
{
    public static QuestionManager instance;

    public List<NPCConversation> ActiveConversations = new List<NPCConversation>();
    List<NPCConversation> InactiveConversations = new List<NPCConversation>();

    [SerializeField]
    NPCConversation noQuestion;

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
        if (GameObject.FindGameObjectWithTag("RobotUI") != null)
            GameObject.FindGameObjectWithTag("RobotUI").SetActive(false);
    }


    public void StartConversation() {
        if (ActiveConversations.Count != 1) {
            int index = Random.Range(1, ActiveConversations.Count);
            ConversationManager.Instance.StartConversation(ActiveConversations[index]);
            InactiveConversations.Add(ActiveConversations[index]);
            ActiveConversations.Remove(ActiveConversations[index]);

        }
        else {
            ActiveConversations = InactiveConversations;
            int index = Random.Range(1, ActiveConversations.Count);
            ConversationManager.Instance.StartConversation(ActiveConversations[index]);
            InactiveConversations.Add(ActiveConversations[index]);
            ActiveConversations.Remove(ActiveConversations[index]);          
        }
    }
        

    public void StartConversation(int conversation) {
        ConversationManager.Instance.StartConversation(ActiveConversations[conversation]);
    }

    


}
