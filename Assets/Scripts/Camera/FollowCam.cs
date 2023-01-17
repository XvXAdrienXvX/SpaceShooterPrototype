using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] 
    private Transform target;
    [SerializeField]
    private Vector3 targetDistance = new Vector3(0f, 2f, -10f);
    [SerializeField]
    private float distanceDamp = 0.2f;
    [SerializeField]
    private float rotationalDamp = 10f;
    private Transform camTransform;

    public Vector3 velocity = Vector3.one;

    private void Awake()
    {
        camTransform = transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        SmoothFollow();
        //Vector3 moveToPosition = target.position + (target.rotation * targetDistance);
        //Vector3 currentPosition = Vector3.Lerp(camTransform.position, moveToPosition, distanceDamp * Time.deltaTime);
        //camTransform.position = currentPosition;

        //Quaternion toRotation = Quaternion.LookRotation(target.position - camTransform.position, target.up);
        //Quaternion currentRotation = Quaternion.Slerp(camTransform.rotation, toRotation, rotationalDamp * Time.deltaTime);
        //camTransform.rotation = currentRotation;
    }

    private void SmoothFollow()
    {
        Vector3 moveToPosition = target.position + (target.rotation * targetDistance);
        Vector3 currentPosition = Vector3.SmoothDamp(camTransform.position, moveToPosition, ref velocity ,distanceDamp * Time.deltaTime);
        camTransform.position = currentPosition;
        camTransform.LookAt(target, target.up);
    }
}
