using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt(gameObject.name) == 1) {
            gameObject.SetActive(false);
        }
            
    }

    public virtual void Collected() {
        PlayerPrefs.SetInt(gameObject.name, 1);
        //LearningModuleManager.instance.ActivateModule();
    }
}
