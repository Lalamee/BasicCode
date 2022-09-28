using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LinearColorChanger : MonoBehaviour
{
    private SpriteRenderer _target;
    [SerializeField] private float _duration;
    [SerializeField] private Color _targetColor;
    private Color _startColor;
    private float _runningTime;
    void Start()
    {
        _target = GetComponent<SpriteRenderer>();
        _startColor = _target.color;
    }

    void Update()
    {
        if (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            float normalizeRunningTime = _runningTime / _duration;
            _target.color = Color.Lerp(_startColor, _targetColor, normalizeRunningTime);
        }
    }
}
