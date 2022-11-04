using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    [SerializeField]
    NPCConversation conversation;

    public int ProgressionIndex;

    private void Awake() {
        instance = this;
        //Application.targetFrameRate = 120;
    }

}
