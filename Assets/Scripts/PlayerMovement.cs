using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 50f;
    [SerializeField]
    private float turnSpeed = 60f;
    [SerializeField]
    Thruster[] thrusters;
    private Transform playerTransform;

    void Awake()
    {
        playerTransform = transform;
    }

    void Update()
    {
        Turn();
        Thrust();         
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");
        playerTransform.Rotate(pitch, yaw, -roll);
    }

    void Thrust()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            playerTransform.position += playerTransform.forward * 
                                        movementSpeed * Time.deltaTime * 
                                        Input.GetAxis("Vertical");

            foreach (Thruster thruster in thrusters)
            {
                thruster.SetIntensity(Input.GetAxis("Vertical"));
            }
        }

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    if (thrusters.Length > 0)
        //    {
        //        for (int index = 0; index < thrusters.Length; index++)
        //        {
        //            thrusters[index].Activate();
        //        }
        //    }
        //}
        //else if (Input.GetKeyUp(KeyCode.W))
        //{
        //    if (thrusters.Length > 0)
        //    {
        //        for (int index = 0; index < thrusters.Length; index++)
        //        {
        //            thrusters[index].Activate(false);
        //        }
        //    }
        //}
    }
}
