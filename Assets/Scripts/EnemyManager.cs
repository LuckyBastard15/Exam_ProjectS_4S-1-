using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    
    public Transform[] _enemySpawnPoints = default;
    public GameObject _enemyPrefab = default;
    public int _speed = 5;
    
    public Transform target;
    public Vector3 offset = new Vector3(0, 0, 20);

    
    private void Update()
        {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);

        }
    
    public void StartEnemy()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1, 2);
    }
    
    
    public void SpawnEnemy()
    {
        int randomNumber = Mathf.RoundToInt(Random.Range(0f, _enemySpawnPoints.Length - 1));
        Instantiate(_enemyPrefab, _enemySpawnPoints[randomNumber].transform.position, _enemySpawnPoints[randomNumber].transform.rotation);
       
    }
}
