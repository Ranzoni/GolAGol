using Unity.Mathematics;
using UnityEngine;

public class IAMove : MonoBehaviour
{
    public float speed = 2f;
    public float range = 6f;

    Rigidbody2D rb2D;
    float direction = 1;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (math.abs(transform.position.y) >= range)
            direction = -direction;

        var yValue = speed * direction;
        rb2D.velocity = new Vector2(rb2D.velocity.x, yValue);
    }
}
