using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;
    private float _speed;

    private void Start()
    {
        _speed = 0;
        _rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Conveyor>(out Conveyor conveyor))
        {
            _speed = collision.gameObject.GetComponent<Conveyor>().GetSpeed();
        }
    }

    private void Update()
    {
        _rigidBody2D.AddForce(Vector2.right * _speed);
    }
}
