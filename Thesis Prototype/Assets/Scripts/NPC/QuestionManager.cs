using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class QuestionManager : MonoBehaviour
{
    public int CurrentIndex = 0;

    public List<NPCConversation> Conversation = new List<NPCConversation>();

    [SerializeField]
    NPCConversation noConvo;

    private void Start() {
        StartCoroutine(checkDialogue());
    }

    public void StartQuestion(NPCConversation conversation) {
        ConversationManager.Instance.EndConversation();
        ConversationManager.Instance.StartConversation(conversation);
    }

    public void StartRandomQuestion() {
        if (Conversation.Count != 0) {
            ConversationManager.Instance.StartConversation(Conversation[CurrentIndex]);
            CurrentIndex++;
            if(CurrentIndex == Conversation.Count) {
                CurrentIndex = 0;
            }
        }
        else {
            ConversationManager.Instance.StartConversation(noConvo);
            gameObject.SetActive(false);
        }
        
    }

    public void AddQuestions(QuestionHolder questions) {
        for(int i = 0; i < questions.Conversation.Count; i++) {
            Conversation.Add(questions.Conversation[i]);
        }
    }
    IEnumerator checkDialogue() {
        if (!ConversationManager.Instance.IsConversationActive) {
            gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(2f);
    }
}
