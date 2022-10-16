using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpForce;

    public void OnPointerClick(PointerEventData eventData)
    {
        _rigidbody.AddForce(Vector2.up * _jumpForce);
    }


}
