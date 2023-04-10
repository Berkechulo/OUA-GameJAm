using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement1 : MonoBehaviour
{
    public float speed = 0.1f;
    private Rigidbody r3d;
    private Animator _animator;

    void Start()
    {
        r3d = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W))
        {
            speed = 3.0f;
        }
        else
        {
            speed = 0.0f;
        }

        _animator.SetFloat("speed", speed);
        r3d.velocity = new Vector3(speed, 0f);
    }
}







