using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class Question
{
    public string text;
    public User user;
    public List<Answer> answers;
    
    public int index = 0;

    public Question(string text, User user)
    {
        this.text = text;
        this.user = user;
        answers = new List<Answer>();
    }

    //Add an answer to the list
    public void AddAnswer(Answer a)
    {
        //make sure this answer has a unique index
        List<int> indicesChecklist = new List<int>();

        for (int i = 0; i < answers.Count; i++)
        {
            indicesChecklist.Add(answers[i].index);
        }

        while (indicesChecklist.Contains(a.index))
        {
            a.index++;
        }

        //add it to the list
        answers.Add(a);
    }

    //Remove an answer from the list, checking the Answer.index value
    public void DeleteAnswer(int index)
    {
        for (int i = 0; i < answers.Count; i++)
        {
            if (answers[i].index == index)
                answers.RemoveAt(i);
        }
    }
}
