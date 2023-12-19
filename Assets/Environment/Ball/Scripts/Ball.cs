using UnityEngine;

public class Ball : MonoBehaviour
{
    public float startForce = 200f;
    public float minimumSpeed = 5f;
    public float speedMultiplier = 1.5f;

    Rigidbody2D rb2D;
    Vector2 startPosition;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        startPosition = transform.localPosition;

        SetDefaultPosition();
    }

    void FixedUpdate()
    {
        if (rb2D.velocity.magnitude < minimumSpeed)
            rb2D.velocity = minimumSpeed * speedMultiplier * rb2D.velocity.normalized;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Goal"))
            return;

        SetDefaultPosition();
    }

    void SetDefaultPosition()
    {
        rb2D.velocity = new Vector2(0, 0);
        transform.localPosition = startPosition;
        rb2D.AddForce(new Vector2(startForce, rb2D.velocity.y));
    }
}
