using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSource : MonoBehaviour
{
    [SerializeField] private Bird birdPRefab;

    public Bird GetBird()
    {
        return Instantiate(birdPRefab, transform.position, Quaternion.identity);
    }
}
