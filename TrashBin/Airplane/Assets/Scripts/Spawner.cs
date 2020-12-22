using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float _timer;
    [SerializeField] private float _countdown;
    [SerializeField] private GameObject _box;

    void Start()
    {
        _timer = _countdown;
    }

    void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            _timer = _countdown;
            Instantiate(_box, transform.position, Quaternion.identity);
        }
    }
}
