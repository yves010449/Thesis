using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class QuestionHolder : MonoBehaviour
{
    public List<NPCConversation> Conversation = new List<NPCConversation>();

    private void Start() {
        foreach (Transform child in transform)
            Conversation.Add(child.GetComponent<NPCConversation>());
    }
}
