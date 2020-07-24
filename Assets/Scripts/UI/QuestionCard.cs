using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionCard : MonoBehaviour
{
    private Question question;
    private Character character;
    [SerializeField] private TMP_Text text;
    [SerializeField] private Image characterHair;
    [SerializeField] private GameObject answerGroup;
    [SerializeField] private GameObject answerCard;

    private void Update() // change to Start later on
    {
        if (DataManager.Instance.activeList == null)
        {
            DataManager.Instance.OpenList(ListType.Local);
        }

        question = DataManager.Instance.GetQuestion();

        character = question.user.character;
        text.text = question.text;

        characterHair.sprite = character.DisplayItem(CharacterItemType.Hair);
    }

    public void OnClick()
    {
        //hide arrows?
        foreach (Answer answer in question.answers)
        {
            GameObject card = Instantiate(answerCard);
            card.transform.parent = answerGroup.transform;

            card.GetComponent<AnswerCard>()?.Initialize(answer);
        }
    }
}
