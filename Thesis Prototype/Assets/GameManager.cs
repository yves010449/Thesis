using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;



    public int ProgressionIndex;

    private void Awake() {
        instance = this;
        Application.targetFrameRate = 120;
    }

}
