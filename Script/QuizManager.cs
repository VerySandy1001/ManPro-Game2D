using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuizManager : MonoBehaviour
{

    int currentLevel;
    public GameObject[] Quizes;


    public void correctAnswer()
    {
        if (currentLevel + 1 != Quizes.Length)
        {
            
            Quizes[currentLevel].SetActive(false);
            // EventManager.OnCoinPlus();

            currentLevel++;
            Quizes[currentLevel].SetActive(true);


        }
    }

    public void WrongAnswer()
    {
        if (currentLevel + 1 != Quizes.Length)
        {
           
            Quizes[currentLevel].SetActive(false);

            currentLevel++;
            Quizes[currentLevel].SetActive(true);
            //EventManager.OnCoinMinus();

        }
    }
}
