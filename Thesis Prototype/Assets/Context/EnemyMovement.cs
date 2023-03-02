using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [SerializeField]
    GameObject playerRef;

    [SerializeField]
    float speed= 10;

    [SerializeField]
    Rigidbody2D rb;
    public Vector2 input{set; get;}
    // Start is called before the first frame update
    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    public  void FixedUpdate()
    {
        
            rb.velocity = input*speed * Time.fixedDeltaTime;
    }
}
