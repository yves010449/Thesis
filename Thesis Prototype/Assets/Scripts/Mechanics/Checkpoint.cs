using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    Transform SpawnPos;
    [SerializeField]
    Sprite sprite;

    SpriteRenderer sr;

    private void Awake() {
        sr = GetComponentInChildren<SpriteRenderer>();
    }



    private void Start() {
        if (PlayerPrefs.GetInt(gameObject.name) == 1) {
            sr.sprite = sprite;
            GameManager.instance.SpawnPos = new Vector2(PlayerPrefs.GetFloat("SpawnPosX"), PlayerPrefs.GetFloat("SpawnPosY"));
        }
        else
            GameManager.instance.SpawnPos = PlayerInput.instance.transform.position;
    }

    public void SetSpawn() {
        PlayerPrefs.SetInt(gameObject.name, 1);
        GameManager.instance.SpawnPos = SpawnPos.position;
        PlayerPrefs.SetFloat("SpawnPosX", SpawnPos.position.x);
        PlayerPrefs.SetFloat("SpawnPosY", SpawnPos.position.y);
        sr.sprite = sprite;
    }


    private void OnTriggerEnter2D(Collider2D collision) {
        //GameManager.instance.SpawnPos = collision.transform.position;
    }
}
