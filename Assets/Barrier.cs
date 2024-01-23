using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] private int hp;

    private const string BarrierTag = "Barrier";

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.TryGetComponent<Bird>(out var enemy))
        {
            gameObject.SetActive(false);
        }

        if (other.collider.CompareTag(BarrierTag))
        {
            hp--;

            if (hp <= 0)
            {
                gameObject.SetActive(false);
            }
        }
    }
}