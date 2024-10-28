using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnswerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Main Camera")
        {
            Debug.Log("Player selecionou: 'Duvido' na resposta");
        }
    }
}
