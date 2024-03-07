using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestionAndAnswer
{
    public string question;
    public string[] answers;
    public int correctAnswer;

    public QuestionAndAnswer(string question, string[] answers, int correctAnswer)
    {
        this.question = question;
        this.answers = answers;
        this.correctAnswer = correctAnswer;
    }
}
