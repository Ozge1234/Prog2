using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI minMaxText;
    [SerializeField] TextMeshProUGUI guessText;

    [SerializeField] int minValue = 1;
    [SerializeField] int maxValue = 100;
    int guess;

    int currentMinValue;
    int currentMaxValue;

    // Start is called before the first frame update
    void Start()
    {
        BeginGame();
    } 

    void BeginGame()
    {
        minMaxText.text = " Think of a number from " + minValue + " to " + maxValue;
        currentMinValue = minValue;
        currentMaxValue = maxValue;
        Guess();
    }

    public void Higher()
    {
        currentMinValue = guess;
        Guess();
    }

    public void Lower()
    {
        currentMaxValue = guess;
        Guess();
    }

    void Guess()
    {
        guess = (currentMaxValue + currentMinValue) / 2;
        guessText.text = " My guess is " + guess;
    }
}
