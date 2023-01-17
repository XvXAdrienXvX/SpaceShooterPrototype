using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
[RequireComponent(typeof(TrailRenderer))]
public class Thruster : MonoBehaviour
{
    private TrailRenderer TrailRenderer;
    private Light thrusterLight;

    private void Awake()
    {
        TrailRenderer = GetComponent<TrailRenderer>();
        TrailRenderer.time = 0.5f;
        TrailRenderer.startWidth = 0.5f;
        TrailRenderer.endWidth = 0;

        thrusterLight = GetComponent<Light>();
    }

    private void Start()
    {
        //TrailRenderer.enabled = false;
        //thrusterLight.enabled = false;
        thrusterLight.intensity = 0;
    }

    public void Activate(bool isActive = true)
    {
        if (isActive)
        {
            TrailRenderer.enabled = true;
            thrusterLight.enabled = true;
        }
        else
        {
            TrailRenderer.enabled = false;
            thrusterLight.enabled = false;
        }
    }

    public void SetIntensity(float intensity)
    {
        thrusterLight.intensity = intensity * 2f;
    }
}
