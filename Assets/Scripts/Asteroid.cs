using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    private float minSize = 0.8f;
    [SerializeField]
    private float maxSize = 1.2f;
    [SerializeField]
    private float rotationOffset = 70f;
    [SerializeField]
    GameObject explosion;
    private Transform asteroidTransform;
    private Vector3 randomRotation;

    void Awake()
    {
        asteroidTransform = transform;
    }

    void Start()
    {
        Vector3 scale = Vector3.one;
        scale.x = Random.Range(minSize, maxSize);
        scale.y = Random.Range(minSize, maxSize);
        scale.z = Random.Range(minSize, maxSize);
        asteroidTransform.localScale = scale;

        randomRotation.x = Random.Range(-rotationOffset, rotationOffset);
        randomRotation.y = Random.Range(-rotationOffset, rotationOffset);
        randomRotation.z = Random.Range(-rotationOffset, rotationOffset);
    }

    void Update()
    {
        asteroidTransform.Rotate(randomRotation * Time.deltaTime);
    }
}
