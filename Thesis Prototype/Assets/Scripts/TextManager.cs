using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class TextManager : MonoBehaviour
{
    TextMeshProUGUI tmp;

    [SerializeField]
    [TextArea(5, 10)]
    string[] texts;

    public int index = 0;

    public UnityEvent OnEnd;

    private void Awake() {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        tmp.SetText(texts[0]);
    }

    public void UpdateText() {
        index++;
        if(index < texts.Length) {
            tmp.SetText(texts[index]);
        }
        else {
            OnEnd?.Invoke();
        }
        
    }
}
