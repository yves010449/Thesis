using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class ShowUI : InteractionDetectors {
    [SerializeField]
    GameObject UI;


    public override void Detect() {
        if (ConversationManager.Instance.IsConversationActive) {
            return;
        }
        if (colliders.Length > 0) {
            UI.SetActive(true);
        }
        else {
            UI.SetActive(false);
        }
    }


}
