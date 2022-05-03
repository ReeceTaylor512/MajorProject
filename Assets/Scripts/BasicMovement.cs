using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private Vector3 movementX;
    [SerializeField] private Vector3 movementY;
    [SerializeField] private float speed;
    private void Update()
    {
       movementX = Vector2.right * Input.GetAxis("Horizontal");
       movementY = Vector2.up * Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + (movementX + movementY) * Time.deltaTime * speed);
    }
}
