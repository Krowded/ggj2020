using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    public Rigidbody rb;
    public KeyCode togglekey;
    public Button button;
    Transform t;
    ParticleSystem p;
    bool particlesOn;
    // Start is called before the first frame update
    void Start()
    {
        p = GetComponentInChildren<ParticleSystem>();
        t = GetComponent<Transform>();
        particlesOn = button.getButtonOn();
        toggleParticles(particlesOn);
        //rb = GetComponent<Rigidbody>();
    }

    void toggleParticles(bool toggle)
    {
        if (toggle)
        {
            p.Play();
        }
        else
        {
            p.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool on = button.getButtonOn();
        if (on != particlesOn)
        {
            toggleParticles(on);
            particlesOn = on;
        }

        if (on)
        {
            rb.AddForceAtPosition(t.forward * Time.deltaTime * -30, t.position);
        }
    }
}
