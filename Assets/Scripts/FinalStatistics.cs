using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class FinalStatistics : MonoBehaviour
{
    [SerializeField] private GameObject statisticsText;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }
    private void Update()
    {
        statisticsText.GetComponent<TextMeshPro>().text = "Acertos: " + gameManager.getNumberRightAnswers() +
            "\n" + "Erros: " + gameManager.getNumberWrongAnswers();
    }
}
