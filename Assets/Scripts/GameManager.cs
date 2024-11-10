using System.Collections;
using System.Collections.Generic;
using DigitalRuby.RainMaker;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private float rainLevel = 0.5f;
    private float dawnDuskLevel = 50f;
    private DemoScript demoScript;
    private int numberRightAnswers = 0;
    private int numberWrongAnswers = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        demoScript = Camera.main.GetComponent<DemoScript>();
        demoScript.RainSliderChanged(rainLevel);
    }

    public void OnTriggerEvent(bool isRightAnswer)
    {
        if (isRightAnswer)
        {
            numberRightAnswers += 1;
            ChangeRainLevel(-0.1f);
            ChangeDawnDuskLevel(20f);
        }
        else
        {
            numberWrongAnswers += 1;
            ChangeRainLevel(0.3f);
            ChangeDawnDuskLevel(-20);
        }
    }

    private void ChangeRainLevel(float value)
    {
        rainLevel += value;
        demoScript.RainSliderChanged(rainLevel);
    }

    private void ChangeDawnDuskLevel(float value)
    {
        dawnDuskLevel += value;
        demoScript.DawnDuskSliderChanged(dawnDuskLevel);
    }

    public int getNumberRightAnswers()
    {
        return numberRightAnswers;
    }

    public int getNumberWrongAnswers()
    {
        return numberWrongAnswers;
    }
}
