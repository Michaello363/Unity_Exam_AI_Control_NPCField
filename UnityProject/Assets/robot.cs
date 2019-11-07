using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : MonoBehaviour
{
    [Header("速度")]
    [Range(0, 100)]
    public int speed = 50;
    [Header("跳躍")]
    [Range(0, 300)]
    public int jump = 0;
    [Header("是否在地上")]
    public bool IsGround = false;

    private Rigidbody r3d;
    // Use this for initialization
    private void Start()
    {
        r3d = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        Jump();
        Walk();
    }
    private void Walk()
    {
        r3d.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0, speed * Input.GetAxis("Vertical")));
    }
    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGround == true)
        {
            IsGround = false;
            r3d.AddForce(new Vector3(0, jump, 0));
        }
    }
}
