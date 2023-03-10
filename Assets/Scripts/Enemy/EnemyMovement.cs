using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    float rotationalDamp = 0.5f;
    [SerializeField]
    float movementSpeed = 20f;

    void Update()
    {
        Turn();
        Move();
    }

    void Turn()
    {
        Vector3 currentPosition = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(currentPosition);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationalDamp * Time.deltaTime);
    }

    void Move()
    {
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
}
