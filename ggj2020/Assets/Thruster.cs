using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    public Rigidbody rb;
    public ParticleSystem particles;
    public ParticleSystem brokenParticles;
    public RepairInteractor repair;

    Transform t;
    bool on = false;
    bool broken = false;

    const float destructionSpeedWhenOn = 0.09f;

    void Start()
    {
        t = GetComponent<Transform>();
        particles.Stop();
        brokenParticles.Stop();
    }

    void updateParticleSystems()
    {
        particles.Stop();
        brokenParticles.Stop();

        if (on || broken)
        {
            repair.destructionSpeed = destructionSpeedWhenOn;
            var particleSystem = broken ? brokenParticles : particles;
            particleSystem.Play();
        }
        else
        {
            repair.destructionSpeed = 0f;
        }
    }

    void Update()
    {
        if (on || broken)
        {
            rb.AddForceAtPosition(t.forward * Time.deltaTime * -30, t.position);
        }
    }

    public void OnButtonPress(bool buttonOn)
    {
        on = buttonOn;
        if (!broken)
            updateParticleSystems();
    }

    public void OnBrokenChange(bool broken)
    {
        this.broken = broken;
        updateParticleSystems();
    }
}
