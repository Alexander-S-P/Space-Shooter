using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject hazard;
    public Vector3 spawnValues;

    public int hazardCount;

    public float SpawnWait;

    public float StartWait;

    public float waveWait;

    public Text scoreText;

    public Text restartText;

    public Text gameoverText;

    private bool gameover;
    
    private int score;

    public void Update()
    {
       
    }

    private void Start()

    {

       score = 0;
       UpdateScore();

        StartCoroutine(SpawnWaves());

    }

        // 
        IEnumerator SpawnWaves()
        {
            yield return new WaitForSeconds(StartWait);

        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = new Quaternion();

                Instantiate(hazard, spawnPosition, spawnRotation);

                yield return new WaitForSeconds(Random.Range(0.5f, SpawnWait));

            }
            yield return new WaitForSeconds(waveWait);

            if(gameover)
            {
           
                break;

            }
        }
        }
    
    void UpdateScore()
    {

       scoreText.text = "Счёт  " + score;

    }
    
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();

    }

    public void GameOver()
    {
   
        gameover = true;
             
        SceneManager.LoadScene("Game Over", LoadSceneMode.Single);

    }
    
}
