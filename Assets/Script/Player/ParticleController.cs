using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] private ParticleSystem touchParticleMain;
    [SerializeField] private ParticleSystem touchParticleBattle;

    private void Start()
    {
        touchParticleMain.Stop(); 
        touchParticleBattle.Stop();
        ParticleSystem.EmissionModule emMain = touchParticleMain.emission;
        ParticleSystem.EmissionModule emBattle = touchParticleBattle.emission;
        emMain.SetBurst(0, new ParticleSystem.Burst(0, 5));
        emBattle.SetBurst(0, new ParticleSystem.Burst(0, 5));
    }
    public void CreateMainParticle(Vector3 position)
    {
        touchParticleMain.transform.position = position;
        touchParticleMain.Stop();
        touchParticleMain.Play();
    }

    public void CreateBattleParticle(Vector3 position)
    {
        touchParticleBattle.transform.position = position;
        touchParticleBattle.Stop();
        touchParticleBattle.Play();
    }
    /*private void DestroyProjectile(Vector3 position, bool createFx)
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
    }*/
}
