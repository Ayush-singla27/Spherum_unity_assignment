using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class generateParticles : MonoBehaviour
{
    public float moveSpeed = 1f;
    public TextMeshProUGUI text;
    void Update()
    {
        ParticleSystem particleSystem = GetComponent<ParticleSystem>();
        ParticleSystem.Particle[] particles = new ParticleSystem.Particle[particleSystem.main.maxParticles];
        int particleCount = particleSystem.GetParticles(particles);

        for (int i = 0; i < particleCount; i++)
        {
            // Randomly move each particle within the sphere
            particles[i].position += Random.onUnitSphere * moveSpeed * Time.deltaTime;

            // Ensure particles stay within the sphere
            particles[i].position = Vector3.ClampMagnitude(particles[i].position, transform.localScale.x * 10f);
        }

        // Set the modified particles back to the system
        particleSystem.SetParticles(particles, particleCount);

        text.text = particleCount.ToString();

    }
}
