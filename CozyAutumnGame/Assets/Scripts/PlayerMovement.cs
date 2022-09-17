using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float velocity = 5f;

    private Rigidbody2D rb;

    private Vector2 directionalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        directionalInput.x = Input.GetAxisRaw("Horizontal");
        directionalInput.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        Vector2 pos = rb.position + directionalInput * velocity * Time.fixedDeltaTime;
        rb.MovePosition(pos);
    }
}
