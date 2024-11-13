using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    private void DestroyProjectile(Vector3 position, bool createFx)
    {
        if (createFx)
        {
            ParticleSystem particleSystem = GameManager.Instance.EffectParticle;

            particleSystem.transform.position = position;
            ParticleSystem.EmissionModule em = particleSystem.emission;
            //em.SetBurst(0, new ParticleSystem.Burst(0, Mathf.Ceil(attackData.size * 5)));
            ParticleSystem.MainModule mainModule = particleSystem.main;
            //mainModule.startSpeedMultiplier = attackData.size * 10f;
            particleSystem.Play();
        }
        gameObject.SetActive(false);
    }
}
