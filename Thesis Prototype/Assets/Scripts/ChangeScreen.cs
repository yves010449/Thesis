using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.UI;

public class ChangeScreen : MonoBehaviour
{

    //[SerializeField]
    //Sprite Panel;

   
    [SerializeField]
    Transform Dialogue_Panel;

    public void SetScreenParent(Transform ScreenParent) {
        //Dialogue_Panel.GetComponent<Image>().sprite = Panel;
        //ConversationManager.Instance.OptionImage = Panel;
        Dialogue_Panel.SetParent(ScreenParent, false);
    }
    public void SetDefaultParent() {
        Dialogue_Panel.SetParent(transform, false);
    }
}
