using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 5f;
    private Rigidbody2D _rb;

    Vector2 _movement;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();   
    }
    // Update is called once per frame
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movement * _moveSpeed * Time.fixedDeltaTime);
    }
}
