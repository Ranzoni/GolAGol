using UnityEngine;

public class RealocateXWall : MonoBehaviour
{
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
        var xValue = (Camera.main.orthographicSize * Screen.width / Screen.height) - transform.localScale.x / 2;

        return anchorLeft ? -xValue : xValue;
    }
}
