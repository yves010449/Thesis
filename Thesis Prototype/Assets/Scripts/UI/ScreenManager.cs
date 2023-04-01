using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI ScreenText;
    ScrollRect scrollRect;

    private void Awake() {
        scrollRect = GetComponentInChildren<ScrollRect>();
    }

    public void SetText(CodeText code) {
        ScreenText.SetText(code.Code);
        scrollRect.verticalNormalizedPosition = 1;
    }
    public void ClearText() {
        ScreenText.SetText("");
        scrollRect.verticalNormalizedPosition = 1;
    }

    private void OnDisable() {
        ClearText();
    }
}
