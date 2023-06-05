using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;

    private void Start()
    {
        // Obtém a pontuação final do GameManager
        int finalScore = GameManager.Instance.GetScore();

        // Atualiza o texto com a pontuação final
        finalScoreText.text = "Score: " + finalScore.ToString();
    }
}