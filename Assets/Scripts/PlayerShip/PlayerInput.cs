using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    Laser[] lasers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (Laser laser in lasers)
            {
                //Vector3 position = transform.position + (transform.forward * laser.Distance);
                laser.Fire(laser.CastRay());
            }
        }
    }
}
