using Unity.Mathematics;
using UnityEngine;

public class RealocateXCharacter : MonoBehaviour
{
    public Transform transformReference;
    public bool anchorLeft;

    float xDistanceBetweenReference;
    bool realocated;

    void Awake()
    {
        xDistanceBetweenReference = DifferenceBetweenXPositions();
        var xValue = DifferenceBetweenXPositions();
        transform.position = new Vector2(xValue, transform.position.y);
    }

    float DifferenceBetweenXPositions()
    {
        return math.abs(transform.position.x - transformReference.position.x);
    }

    void Update()
    {
        if (realocated)
            return;

        var xValue = anchorLeft ? transformReference.position.x + xDistanceBetweenReference : transformReference.position.x - xDistanceBetweenReference;
        transform.position = new Vector2(xValue, transform.position.y);
        realocated = true;
    }
}
