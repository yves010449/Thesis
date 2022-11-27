using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Respawn : MonoBehaviour
{
    public UnityEvent OnRespawn;

    public void RespawnPlayer() {
        transform.position = GameManager.instance.SpawnPos;
        OnRespawn?.Invoke();
    }
}
