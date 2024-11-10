using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class AnswerZone : MonoBehaviour
{
    [SerializeField] private GameObject Answer;
    [SerializeField] private bool isRightAnswer;
    [SerializeField] private UnityEvent<bool> OnTriggerEvent;
    private bool wasItAnswered = false;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Main Camera" && !wasItAnswered)
        {
            OnTriggerEvent?.Invoke(isRightAnswer);

            Debug.Log("Player selecionou:" + "'" + Answer.GetComponentInChildren<TextMeshPro>().text + "'" + "na resposta");

            wasItAnswered = true;
        }
    }
}
