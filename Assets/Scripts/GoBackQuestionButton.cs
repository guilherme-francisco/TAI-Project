using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBackQuestionButton : MonoBehaviour
{
    [SerializeField] private Vector3 position;
    [SerializeField] private Vector3 rotation;
    [SerializeField] private Button button;
    [SerializeField] private GameObject xrOrigin;
    private void Awake()
    {
        button.onClick.AddListener(() =>
        {
            xrOrigin.transform.position = position;
            xrOrigin.transform.rotation = Quaternion.Euler(rotation);

            Transform mainCameraTransform = Camera.main.transform;
            mainCameraTransform.position = Vector3.zero;
            mainCameraTransform.rotation = Quaternion.Euler(Vector3.zero);
        });
    }

}
