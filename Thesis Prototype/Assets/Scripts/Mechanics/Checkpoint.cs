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
        GameManager.instance.SpawnPos = PlayerInput.instance.transform.position;
    }

    public void SetSpawn() {
        GameManager.instance.SpawnPos = SpawnPos.position;
        sr.sprite = sprite;
    }


    private void OnTriggerEnter2D(Collider2D collision) {
        //GameManager.instance.SpawnPos = collision.transform.position;
    }
}
