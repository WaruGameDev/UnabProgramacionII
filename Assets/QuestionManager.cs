using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public List<Question> questions;
    public TextMeshProUGUI question, reply1, reply2, reply3;
    public List<Reply> replies;
    // Start is called before the first frame update
    void Start()
    {
        CallQuestion(0);
    }

    public void CallQuestion(int i)
    {
        question.text = questions[i].question;
        reply1.text = questions[i].replies[0];
        reply2.text = questions[i].replies[1];
        reply3.text = questions[i].replies[2];
        replies[questions[i].correctAnswer].isCorrect = true;
    }

}
