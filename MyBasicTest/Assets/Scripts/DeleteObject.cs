using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    void Start()
    {
        GameObject objectToDelete = GameObject.Find("Circle");
        Destroy(objectToDelete);
    }
}
