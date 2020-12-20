﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _trash;

    private Vector3 _mousePosition;




    private void Update()
    {
        _mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_trash, _mousePosition, Quaternion.identity);
        }
    }
}