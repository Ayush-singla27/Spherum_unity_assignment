using UnityEngine;

public class ParticleStreamController : MonoBehaviour
{
    public Transform targetCube; 
    private ParticleSystem particleSystem;

    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (targetCube != null)
        {
            transform.LookAt(targetCube);
            particleSystem.Emit(1);
        }
    }
}
