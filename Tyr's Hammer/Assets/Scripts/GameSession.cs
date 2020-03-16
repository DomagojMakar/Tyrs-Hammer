using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] float deathWait = 1f;
    [SerializeField] int playerLives = 6;
    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Awake()
    {
        int numOfGameSessions = FindObjectsOfType<GameSession>().Length;
        if(numOfGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        SetTexts();
    }

    public void ProcessPlayerDeath()
    {
        if(playerLives > 1)
        {
            ReduceLife();
        }
        else
        {
            ResetGameSession();
        }
    }

    public void AddToScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.SetText("Score: " + score.ToString());
    }

    private void ReduceLife()
    {
        StartCoroutine(DeathWait());
    }

    IEnumerator DeathWait()
    {
        playerLives--;

        yield return new WaitForSecondsRealtime(deathWait);
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        livesText.SetText("Lives: " + playerLives.ToString());
        SceneManager.LoadScene(currentSceneIndex);
    }

    private void ResetGameSession()
    {
        playerLives = 3;
        score = 0;
        SetTexts();
        SceneManager.LoadScene(0);
    }

    private void SetTexts()
    {
        livesText.SetText("Lives: " + playerLives.ToString());
        scoreText.SetText("Score: " + score.ToString());
    }
}
