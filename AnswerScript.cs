using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    
    public void Answers()
    {
        if(isCorrect)
        {
           
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else 
        {
           
           Debug.Log("Wrong Answer");
           quizManager.wrong(); 
        }
    }
}