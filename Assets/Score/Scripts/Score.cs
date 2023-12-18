using UnityEngine;

public class Score : MonoBehaviour
{
    int points;

    public int Points { get { return points; } }

    public void SetPoint(int amount)
    {
        points += amount;
    }
}
