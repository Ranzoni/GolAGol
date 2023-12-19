using UnityEngine;

public class CharacterKick : MonoBehaviour
{
    public float kickForce = 10f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Ball"))
            return;

        if (other.TryGetComponent<Rigidbody2D>(out var rb2d))
        {
            rb2d.velocity = new Vector2(0, 0);
            rb2d.AddRelativeForce(new Vector2(kickForce, rb2d.velocity.y));
            var collisionDirection = other.transform.position - transform.position;
            rb2d.velocity = kickForce * collisionDirection;
        }
    }
}
