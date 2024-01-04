using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlscenceScript : MonoBehaviour
{
    public void gotoLeaning()
    {
        SceneManager.LoadScene("LEARN");
    }

    public void gotoQuiz()
    {
        SceneManager.LoadScene("quiz");
    }
    public void gotoUI()
    {
        SceneManager.LoadScene("UI");
    }
    public void Close()
    {
        Application.Quit();
    }
}