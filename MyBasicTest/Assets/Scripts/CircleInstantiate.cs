using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private int _count;
    [SerializeField] private int _radius;

    void Start()
    {
        int angelStep = 360 / _count;
        for (int i = 0; i < _count; i++)
        {
            GameObject newObject = Instantiate(_template, new Vector3(0, 0, 0), Quaternion.identity);
            Transform newObjectTransform = newObject.GetComponent<Transform>();
            newObjectTransform.position = new Vector3(_radius * Mathf.Cos(angelStep * (i + 1)* Mathf.Deg2Rad) ,_radius * Mathf.Sin(angelStep * (i + 1) * Mathf.Deg2Rad), 0);
        }
    }
}
