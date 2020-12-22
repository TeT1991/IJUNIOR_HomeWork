using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    private Rigidbody _rigidBody;


    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.mass = Random.Range(0.5f, 3f);
    }

    public void EnableKinematic ()
    {
        _rigidBody.isKinematic = true;
    }

    public float GetMass ()
    {
        return _rigidBody.mass;
    }
}
