using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public enum ListType { Local, Global }

public class DataManager : MonoBehaviour
{
    private static DataManager instance;

    public static DataManager Instance
    {
        get
        {
            return instance;
        }
    }
    
    public Dictionary<ListType, DataList> lists;

    private DataList activeList;
    private int activeIndex; // not to be confused with the index field of class Question
    public Question activeQuestion;

    private void Awake()
    {
        instance = this;

        //localList = new DataList();
        //localList.Initialize("local.json");

        lists = new Dictionary<ListType, DataList>()
        {
            {ListType.Local, new DataList() },
            {ListType.Global, new DataList() }
        };

        lists[ListType.Local].Initialize("local.json");
        lists[ListType.Global].Initialize("global.json");
        
    }

    private void Start()
    {
        /*localList.AddQuestion(new Question("how to play?", new User()));
        localList.AddQuestion(new Question("how to play?", new User()));

        for (int i=0; i<localList.questions.Count; i++)
        {
            localList.questions[i].AddAnswer(new Answer("fuk off"));
            localList.questions[i].AddAnswer(new Answer("git gud"));
        }*/

        
    }

    private void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            localList.Save();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            localList.Load();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            localList.Clear();
        }
        */
    }

    public void OpenList(ListType listType)
    {
        activeList = lists[listType];
    }

    public void CloseList()
    {
        activeList = null;
    }

    public void SubmitQuestion(string input, User user)
    {
        if (activeList == null)
        {
            Debug.LogError("No list selected!");
            return;
        }

        activeList.AddQuestion(new Question(input, user));
    }

    public void PreviousQuestion()
    {
        if (activeList == null)
        {
            Debug.LogError("No list selected!");
            return;
        }

        if (activeIndex == 0)
        {
            activeIndex = activeList.questions.Count - 1;
        }
        else
        {
            activeIndex--;
        }
        activeQuestion = activeList.questions[activeIndex];
    }

    public void NextQuestion()
    {
        if (activeList == null)
        {
            Debug.LogError("No list selected!");
            return;
        }

        if (activeIndex == activeList.questions.Count - 1)
        {
            activeIndex = 0;
        }
        else
        {
            activeIndex++;
        }
        activeQuestion = activeList.questions[activeIndex];
    }

    
    public Question GetQuestion(int index)
    {
        if (activeList==null)
        {
            Debug.LogError("No list selected!");
            return null;
        }

        return activeList.questions[index];
    }
    
}
