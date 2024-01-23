using UnityEngine;
using UnityEngine.Events;

public class ShotPoint : MonoBehaviour
{
    [SerializeField] private float maxDistance = 3;
    private Vector2 startPoint;

    public UnityEvent<Vector2> onRelease;

    private Camera camera;


    void Start()
    {
        startPoint = transform.position;
        camera = Camera.main;
    }

    void OnMouseDrag()
    {
        Vector2 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);

        if (Vector3.Distance(startPoint, mousePosition) < maxDistance)
        {
            transform.position = mousePosition;
        }
        else
        {
            var direction = (mousePosition - startPoint).normalized * maxDistance;
            transform.position = startPoint + direction;
        }
    }

    void OnMouseUp()
    {
        Vector2 releasePosition = transform.position;
        transform.position = startPoint;

        Vector2 delta = releasePosition - startPoint;

        onRelease?.Invoke(delta.normalized * (delta.magnitude / maxDistance));
    }
}
