using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    public Player _player;
    public Player Player
    {
        get { return _player; }
        set { _player = value; }
    }

    public BossManager bossManager;
    public bool Is_Battle;//전투중인지

    public ParticleSystem EffectParticle;

    void Awake()
    {
        Time.timeScale = 1;
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance != this)
            {
                Destroy(gameObject);
            }
        }

        Is_Battle = false;
        EffectParticle = GameObject.FindGameObjectWithTag("Particle").GetComponent<ParticleSystem>();
    }
}
