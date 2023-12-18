using UnityEngine;

public class ResizeHorizontalWall : MonoBehaviour
{
    void Start()
    {
        Resize();
        Relocation();
    }

    void Resize()
    {
        var width = Camera.main.orthographicSize * 2f * Screen.width / Screen.height;
        transform.localScale = new Vector2(width, transform.localScale.y);
    }

    void Relocation()
    {
        transform.localPosition = new Vector2(0, transform.localPosition.y);
    }
}
