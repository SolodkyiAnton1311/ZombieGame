using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
    {
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private GameObject gameOver;
    private float waveCount;
    private static GameManager _instance;
    public static GameManager Instance =>_instance ;
    private float waveMultiplayer;
    private float currentWave;


    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            return;
        }
        Destroy(gameObject);
    }

    private void Start()
    {
        waveCount = 1;
        waveMultiplayer = 5;
        InitNewWave();
    }
    

    public void GameOver()
    {
        gameOver.SetActive(true);
    }

    public void EndWave()
    {
        waveCount++;
        Invoke("InitNewWave",5f);
    }

    public void ZombieDie()
    {
        currentWave++;
        LevelSliderController.Instance.UpdateLevelSlider(currentWave/(waveCount*waveMultiplayer));
        if (Mathf.Approximately(currentWave, waveCount * waveMultiplayer))
        {
            EndWave();
        }
    }

    public void InitNewWave()
    {
        currentWave = 0;
        LevelSliderController.Instance.UpdateLevelText(waveCount);
        LevelSliderController.Instance.UpdateLevelSlider(0);
        _enemySpawner.StartWave(waveCount * waveMultiplayer);
    }
    

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}