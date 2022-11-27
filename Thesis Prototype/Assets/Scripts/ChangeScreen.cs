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
    Image img;

    public void SetScreenParent(Transform ScreenParent) {
        //img = Dialogue_Panel.GetComponent<Image>();
        //img.color = new Color(img.color.r, img.color.g, img.color.b, 0);
        //Dialogue_Panel.GetComponent<Image>().sprite = Panel;
        //ConversationManager.Instance.OptionImage = Panel;
        Dialogue_Panel.SetParent(ScreenParent, false);
    }
    public void SetDefaultParent() {
        //img.color = new Color(img.color.r, img.color.g, img.color.b, 1);
        Dialogue_Panel.SetParent(transform, false);
    }
}
