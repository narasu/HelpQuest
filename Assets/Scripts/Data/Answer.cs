using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class Answer
{
    public string answer;
    public User user = new User();
    public int index = 0;

    public Answer(string answer)
    {
        this.answer = answer;
    }
}