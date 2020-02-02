using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairMeter : MonoBehaviour
{
    public Thruster thruster;

    [Range(0,1)]
    public float brokenness = 0;

    public Color broken;
    private Vector3 hsvBroken;
    public Color repaired;
    private Vector3 hsvRepaired;

    private float lastFrameBrokenness;
    private Material material;

    void Start()
    {
        var renderer = GetComponent<Renderer>();
        material = new Material(renderer.material);
        renderer.material = material;
    }

    // Update is called once per frame
    void Update()
    {
        if (brokenness != lastFrameBrokenness)
        {
            if (brokenness == 0.0f)
            {
                thruster.OnBrokenChange(broken: false);
            }
            if (brokenness == 1.0f)
            {
                thruster.OnBrokenChange(broken: true);
            }

            lastFrameBrokenness = brokenness;
            float startIntensity = repaired.r + repaired.g + repaired.b;
            float goalIntensity = broken.r + broken.g + broken.b;
            float currentIntensity = Mathf.Lerp(startIntensity, goalIntensity, brokenness);
            var lerpedColor = Color.Lerp(repaired, broken, brokenness);
            float intensityLerped = lerpedColor.r + lerpedColor.g + lerpedColor.b;

            material.color = lerpedColor * (currentIntensity / intensityLerped);
        }
    }
}
