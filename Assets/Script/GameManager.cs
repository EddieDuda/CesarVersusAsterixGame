using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public enum SceneType
    {
        RomeLevel,
        GaliaLevel
    }

    public float gameTimeRome = 60f; // Tempo total de jogo na cena RomeLevel em segundos (10 minutos)
    public float gameTimeGalia = 60f; // Tempo total de jogo na cena GaliaLevel em segundos (1 minuto)
    public int maxScoreRome = 30;
    public int maxScoreGalia = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI vidaText;

    private float timer;
    private int vida = 0;
    private int score = 0;
    private bool isGameOver = false;
    private SceneType currentSceneType;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        timer = GetGameTime(); // Defina o tempo inicial com base na cena atual
        currentSceneType = GetSceneType(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        if (!isGameOver)
        {
            UpdateTimer();

            if (timer <= 0f)
            {
                isGameOver = true;
                if (currentSceneType == SceneType.RomeLevel)
                {
                    SceneManager.LoadScene("DerrotaAsterix");
                }
                else if (currentSceneType == SceneType.GaliaLevel)
                {
                    SceneManager.LoadScene("DerrotaCesar");
                }
            }

            if (currentSceneType == SceneType.RomeLevel)
            {
                if (score >= maxScoreRome)
                {
                    isGameOver = true;
                    SceneManager.LoadScene("VitoriaAsterix");
                }
                CheckPlayerPositionRomeLevel();
            }
            else if (currentSceneType == SceneType.GaliaLevel)
            {
                CheckPlayerPositionGaliaLevel();
            }
        }
    }

    private void UpdateTimer()
    {
        timer -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);

        string timeText = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = "Time: " + timeText;
    }

    private void CheckPlayerPositionRomeLevel()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector2 playerPosition = player.transform.position;

        if (playerPosition.x <= -11.71f && playerPosition.y >= 2.02f)
        {
            isGameOver = true;
            SceneManager.LoadScene("VitoriaAsterix");
        }
    }

    private void CheckPlayerPositionGaliaLevel()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector2 playerPosition = player.transform.position;

        if (playerPosition.x >= 66.28f && playerPosition.y == -1.8f)
        {
            isGameOver = true;
            SceneManager.LoadScene("VitoriaCesar");
        }
    }

    public void AddPoints(int points)
    {
        score += points;

        if (currentSceneType == SceneType.RomeLevel)
        {
            if (score > maxScoreRome)
            {
                maxScoreRome = score;
            }
        }
        else if (currentSceneType == SceneType.GaliaLevel)
        {
            if (score > maxScoreGalia)
            {
                maxScoreGalia = score;
            }
        }

        UpdateScoreText(); // Atualiza o score no texto
    }

    public void LosePoints(int points)
    {
        score -= points;

        UpdateScoreText(); // Atualiza o score no texto
    }

    public void SetPlayerLife(int vida)
    {
        this.vida = vida;
        vidaText.text = "Vida: " + vida.ToString();
    }

    public void DecreasePlayerLife()
    {
        vida--;
        vidaText.text = "Vida: " + vida.ToString();

        if (vida <= 0)
        {
            isGameOver = true;
            if (currentSceneType == SceneType.RomeLevel)
            {
                SceneManager.LoadScene("DerrotaAsterix");
            }
            else if (currentSceneType == SceneType.GaliaLevel)
            {
                SceneManager.LoadScene("DerrotaCesar");
            }
        }
    }

    public SceneType GetSceneType(string sceneName)
    {
        if (sceneName.Equals("RomeLevel"))
        {
            return SceneType.RomeLevel;
        }
        else if (sceneName.Equals("GaliaLevel"))
        {
            return SceneType.GaliaLevel;
        }

        return SceneType.RomeLevel;
    }

    private float GetGameTime()
    {
        if (currentSceneType == SceneType.RomeLevel)
        {
            return gameTimeRome;
        }
        else if (currentSceneType == SceneType.GaliaLevel)
        {
            return gameTimeGalia;
        }

        return 0f;
    }

    private void UpdateScoreText()
    {
        string scoreString = "Score: " + score.ToString();

 

        scoreText.text = scoreString;
    }

    public int GetScore()
    {
        return score;
    }
}