using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private ContactFilter2D _filter;
    [SerializeField] private float _speed;

    private readonly RaycastHit2D[] _results = new RaycastHit2D[1];
    
    private void FixedUpdate()
    {
        var collisionCount = _rigidbody.Cast(transform.right, _filter, _results, 10);

        if (collisionCount == 0)
            _rigidbody.velocity = transform.right * _speed;
        else
            _rigidbody.velocity = Vector2.zero;

    }
}
