using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D selfRigidbody;
    private bool MoveLeft;
    private bool MoveRight;
    private bool MoveDown;
    private bool MoveUp;
    public float speed;
    // Start is called before the first frame update
    void Start()

    {
        selfRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
     MoveLeft=Input.GetKey (KeyCode.A);
        MoveDown= Input.GetKey(KeyCode.S);
        MoveRight= Input.GetKey(KeyCode.D);
        MoveUp=Input.GetKey(KeyCode.W);
    }
    // Fixed update is called every x to x ms
      private void FixedUpdate()
    {
        
        float currSpeed = 0;
        if (MoveLeft) currSpeed -= speed;
        if (MoveRight) currSpeed += speed;
        selfRigidbody.velocity = new Vector2(currSpeed,selfRigidbody.velocity.y);
    }    

    }

