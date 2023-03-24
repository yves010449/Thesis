using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    Button button;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("CurrentLevel")) {
            button.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
