﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpwaner : MonoBehaviour
{
    
    public enum SpawnState { Spawning, Waiting, Counting};
    [System.Serializable]
    public class wave
    {
        public string WaveName;
        public Transform enemy;
        public int count;
        public float SpawnRate;
    }
    private SpawnState state = SpawnState.Counting;
    public wave[] waves;
    private int NextWave = 0;

    public float TimeBetweenWaves = 5f;
    public float WaveCountDown;
    private float SearchCountDown = 1f;
    public Transform[] SpawnPoints;
    bool EnemyIsAlive()
    {
        SearchCountDown -= Time.deltaTime;
        if (SearchCountDown <= 0f)
        {
            SearchCountDown = 1f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
        return true;
    }
    void SpawnEnemy(Transform Enemy)
    {
        Debug.LogWarning("Spawning: " + Enemy.name);
        for (int i = 0; i < SpawnPoints.Length ; i++)
        {
            Transform spawnPoints = SpawnPoints[i];
            Instantiate(Enemy, spawnPoints.position, spawnPoints.rotation);
        }
     
        
    }

    IEnumerator SpawnWave(wave Wave)
    {
        Debug.LogWarning("Spawning Wave: " + Wave.WaveName);
        state = SpawnState.Spawning;
        for(int i = 0; i< Wave.count; i++)
        {
            SpawnEnemy(Wave.enemy);
            yield return new WaitForSeconds(1f / Wave.SpawnRate);
        }
        state = SpawnState.Waiting;
        yield break;
    }

    void WaveCompleted()
    {
        Debug.Log("Wave Completed");
        state = SpawnState.Counting;
        WaveCountDown = TimeBetweenWaves;

        if (NextWave + 1 > waves.Length - 1) 
        {
            NextWave = 0;
            Debug.LogWarning("All waves completed");
        }
        else
        {
            NextWave++;
        }
    }

    
   private void Start()
    {
        if (SpawnPoints.Length == 0)
        {
            Debug.LogError("Error!: No SpawnPoints");
        }
        WaveCountDown = TimeBetweenWaves;
    }

    
    void Update()
    {
        if (state == SpawnState.Waiting)
        {
            if (!EnemyIsAlive())
            {
                WaveCompleted();
                
            }
            else
                return;
        }
        if (WaveCountDown <= 0)
        {
            if (state != SpawnState.Spawning)
            {
                StartCoroutine(SpawnWave(waves[NextWave]));
            }
        }
        else
            WaveCountDown -= Time.deltaTime;
    }
}
