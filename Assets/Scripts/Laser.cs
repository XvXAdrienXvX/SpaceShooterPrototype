using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
[RequireComponent(typeof(LineRenderer))]
public class Laser : MonoBehaviour
{
    [SerializeField]
    float timeForLaserOff = 0.5f;
    [SerializeField]
    float maxDistance = 300f;
    [SerializeField]
    float fireDelay = 2f;
    LineRenderer lineRenderer;
    bool canFire;
    Light laserLight;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        laserLight = GetComponent<Light>();
    }

    private void Start()
    {
        lineRenderer.enabled = false;
        laserLight.enabled = false;
        canFire = true;
    }

    public Vector3 CastRay()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * maxDistance;

        if (Physics.Raycast(transform.position, forward, out hit))
        {
            hit.transform.GetComponent<Explosion>().Hit(hit.point);
            return hit.point;
        }
       
        return transform.TransformDirection(Vector3.forward) * maxDistance;
    }

    public void Fire(Vector3 targetPosition)
    {
        if (canFire)
        {
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, targetPosition);
            lineRenderer.enabled = true;
            canFire = false;
            laserLight.enabled = true;
            Invoke("TurnOffLaser", timeForLaserOff);
            Invoke("EnableFireMode", fireDelay);
        }
    }

    public void TurnOffLaser()
    {
        lineRenderer.enabled = false;
        canFire = true;
        laserLight.enabled = false;
    }

    public float Distance
    {
        get { return maxDistance; }
    }

    private void EnableFireMode()
    {
        canFire = true;
    }
}
