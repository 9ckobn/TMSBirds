using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class BirdTransfer
{
    [SerializeField] private float animtionDuration = 1;
    [SerializeField] private float animationForce = 2;

    public IEnumerator TransferBird(Bird bird, Vector3 target)
    {
        yield return bird.transform.DOJump(target, animationForce, 1, animtionDuration).WaitForCompletion();
    }
}