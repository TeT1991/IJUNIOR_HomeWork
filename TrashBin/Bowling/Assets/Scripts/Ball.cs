using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _speed;
    Rigidbody _rigidBody;
    private bool _isMoving;

    private void Start()
    {
        _rigidBody = gameObject.GetComponent<Rigidbody>();
        _isMoving = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) & !_isMoving)
        {
            _isMoving = true;
            _rigidBody.AddForce(Vector3.forward * _speed);
        }
    }
}
