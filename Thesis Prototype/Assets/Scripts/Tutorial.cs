using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class Tutorial : MonoBehaviour
{

    [SerializeField]
    NPCConversation conversation;
    // Start is called before the first frame update
    void Start()
    {
        ConversationManager.Instance.EndConversation();
        ConversationManager.Instance.StartConversation(conversation);
    }


}
