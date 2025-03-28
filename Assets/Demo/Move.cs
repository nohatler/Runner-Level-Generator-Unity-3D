using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0f, 0f, 0.2f);
        _rb.MovePosition(_rb.position + direction);
    }
}
