using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class Narrator : MonoBehaviour
{

    public NPCConversation[] Conversation;

    void Start()
    {
        ConversationManager.Instance.StartConversation(Conversation[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
