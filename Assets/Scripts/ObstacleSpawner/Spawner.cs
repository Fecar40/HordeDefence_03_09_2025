using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _timer;
    [SerializeField] private float _spawnPeriod;

    private readonly Vector2 _xRange = new Vector2(-5f, 5f);
    private ObstacleList _obstacleList;

    private void Awake()
    {
        _obstacleList = GetComponent<ObstacleList>();
    }

    private void Update()
    {
        _timer += Time.unscaledDeltaTime;
        if (_timer > _spawnPeriod)
        {
            Spawn(GetRandomObstacle());
        }
    }
    private void Spawn(GameObject obstacle)
    {
        _timer = 0;
        GameObject newObstacle = Instantiate(obstacle,obstacle.transform.position = new Vector3(Random.Range(_xRange.x, _xRange.y), transform.position.y + 0.5f, transform.position.z), Quaternion.identity);
    }

    private GameObject GetRandomObstacle()
    {
        float totalChance = 0f;

        foreach (var obstacle in _obstacleList.Obstacles)
        {
            totalChance += obstacle.SpawnChance;
        }
        float randomPoint = Random.value * totalChance;

        foreach (var obstacle in _obstacleList.Obstacles)
        {
            if (randomPoint < obstacle.SpawnChance)
            {
                return obstacle.Prefab;
            }
            else
            {
                randomPoint -= obstacle.SpawnChance;
            }
        }
        return null;
    }
}
