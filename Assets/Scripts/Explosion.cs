using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Explosion : MonoBehaviour
{
    [SerializeField]
    GameObject explosion;

    public void Hit(Vector3 position)
    {
        GameObject gameObject = Instantiate(explosion, position, Quaternion.identity, transform);
        Destroy(gameObject, 6f);
    }
}
