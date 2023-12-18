using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 2f;

    InputActions controls;
    float direction = 0;
    Rigidbody2D rb2D;

    void Awake()
    {
        controls = new InputActions();
        controls.Enable();
        controls.Player.Move.performed += ctx => 
        {
            direction = ctx.ReadValue<float>();
        };

        controls.Player.Move.canceled += ctx => 
        {
            direction = 0;
        };
    }

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

     void FixedUpdate()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, direction * speed);
    }
}
