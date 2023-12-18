using UnityEngine;

public class Goal : MonoBehaviour
{
    public int pointGoal = 1;
    public Score score;
    public bool anchorLeft = true;

    void Start()
    {
        Relocation();
    }

    void Relocation()
    {
        var xValue = CalculatedXPosition();
        transform.localPosition = new Vector2(xValue, transform.localPosition.y);
    }

    float CalculatedXPosition()
    {
        var xValue = (Camera.main.orthographicSize * Screen.width / Screen.height) + transform.localScale.x;

        return anchorLeft ? -xValue : xValue;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.tag.Equals("Ball"))
            return;

        score.SetPoint(pointGoal);
    }
}
