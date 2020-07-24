using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerCard : MonoBehaviour
{
    Answer answer;
    Character character;
    [SerializeField] private TMP_Text text;

    public void Initialize(Answer answer)
    {
        this.answer = answer;
        text.text = this.answer.answer;
    }
}
