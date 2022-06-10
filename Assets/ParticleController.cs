using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject particle;

    public void StartParticles(bool e)
    {
        particle.SetActive(e);
    }
}
