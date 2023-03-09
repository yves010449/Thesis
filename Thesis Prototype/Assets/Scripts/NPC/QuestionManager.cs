using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class QuestionManager : MonoBehaviour
{
    public static QuestionManager instance;

    public List<NPCConversation> Conversations = new List<NPCConversation>();
    int conversationIndex = 0;

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
        Debug.Log(Conversations.Count);
        if (Conversations.Count != 1) {
            ConversationManager.Instance.StartConversation(Conversations[Random.Range(1,Conversations.Count)]);
        }
        else {
            ConversationManager.Instance.StartConversation(Conversations[0]);
        }
    }
        

    public void StartConversation(int conversation) {
        ConversationManager.Instance.StartConversation(Conversations[conversation]);
    }

    


}
