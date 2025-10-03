using UnityEngine;
using System;

[RequireComponent(typeof(Timer))]

public class BossSpawner : MonoBehaviour
{
    [SerializeField] private Timer _timer;

    [SerializeField] private GameObject _bossPrefab;

    [SerializeField] private Timer _spawnerTimer;

    internal event Action<GameObject> Spawned;


    private void SpawnBoss()
    {
        //_spawnerTimer.IsRunning(false);
        GameObject boss = Instantiate(_bossPrefab, new Vector3(0,0,0), Quaternion.identity);
        Spawned?.Invoke(boss);
    }
}
