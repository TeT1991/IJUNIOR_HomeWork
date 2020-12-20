using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [SerializeField] private float _speed;

    public float GetSpeed()
    {
        return _speed;
    }
}
