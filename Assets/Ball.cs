using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public enum Direction
    {
        Right,
        Left,
    }
    Direction direction = Direction.Right;
    // Update is called once per frame
    public float speed = 5f;
    private Quaternion originalRote;
    public Text pointText;
    int point = 0;
    public float gameOverHeight = 1.3f;
    private void Start()
    {

        originalRote = transform.rotation;
    }

    void Update()
    {
        if(transform.position.y < gameOverHeight)
        {
            Debug.Log("게임오버");
            return;
        }

        if(Input.anyKeyDown)
        {
            direction = (direction == Direction.Right) ? Direction.Left : Direction.Right;
            var velocity = GetComponent<Rigidbody>().velocity;
            velocity.x = 0;
            velocity.z = 0;
            GetComponent<Rigidbody>().velocity = velocity;
            pointTextAdd(1);
        }
        transform.rotation = originalRote;

        BallMove();
    }

    private void pointTextAdd(int point)
    {
        this.point += point;
        pointText.text = this.point.ToString();
    }

    private void BallMove()
    {
        Vector3 move = (direction == Direction.Right) ? new Vector3(1, 0, 0) : new Vector3(0, 0, 1);
        transform.Translate(move * speed * Time.deltaTime, Space.Self);
    }
}
