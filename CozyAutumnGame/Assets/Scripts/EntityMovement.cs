using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    public float velocity;
    public Vector2 directionToMove;
    private Rigidbody2D rb;

    // Awake is called either when an active GameObject that contains the script is initialized when a Scene loads,
    // or when a previously inactive GameObject is set to active, or after a GameObject created with Object.Instantiate
    // is initialized.
    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = rb.position + directionToMove * velocity * Time.fixedDeltaTime;
        rb.MovePosition(pos);
    }
}
