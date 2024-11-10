using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ManagerGroupAnswers : MonoBehaviour
{
    [SerializeField] private GameObject rightAnswerSign;
    [SerializeField] private GameObject wrongAnswerSign;


    public void OnWrongAnswerTrigger(bool value)
    {
        rightAnswerSign.GetComponentInChildren<AnswerZone>().gameObject.SetActive(false);
    }
}
