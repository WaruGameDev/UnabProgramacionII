using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Question", menuName = "QuizGame/Question", order = 1)]
public class Question : ScriptableObject
{
    public string question;
    public int correctAnswer;
    public List<string> replies;
}
