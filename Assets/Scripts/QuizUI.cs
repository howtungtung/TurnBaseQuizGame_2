using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class QuizUI : MonoBehaviour
{
    public UnityEvent onAnswerCorrect;
    public UnityEvent onAnswerWrong;
    private QuizData quizData;
    public Text quizText;
    public Text optionAText;
    public Text optionBText;
    public Text optionCText;
    public Text optionDText;

    public void Show(QuizData quizData)
    {
        this.quizData = quizData;
        quizText.text = quizData.quiz;
        optionAText.text = quizData.optionA;
        optionBText.text = quizData.optionB;
        optionCText.text = quizData.optionC;
        optionDText.text = quizData.optionD;
        gameObject.SetActive(true);
    }
}
