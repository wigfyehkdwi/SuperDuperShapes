using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] shapePrefabs;
    public float spawnDelay = 2f;
    public float spawnTime = 3f;
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {
        int prefabIndex = Random.Range(0, shapePrefabs.Length);
        Instantiate(shapePrefabs[prefabIndex], Vector3.zero, Quaternion.identity);
    }

    public void GameOver()
    {
        CancelInvoke("Spawn");
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
