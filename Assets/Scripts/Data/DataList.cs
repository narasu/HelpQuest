using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

[Serializable]
public class DataList
{
    private DataList loadedList;
    public List<Question> questions;

    private string json;
    private string fileName = "";
    
    //Initialize the list
    public void Initialize(string fileName)
    {
        this.fileName = fileName;
        //create new list
        questions = new List<Question>();

        //load list if one exists
        Load();

        if (loadedList == null)
        {
            loadedList = this;
        }
        else
        {
            questions = loadedList.questions;
        }
    }

    //Add a question to the list
    public void AddQuestion(Question q)
    {
        //make sure this question has a unique index
        List<int> indicesChecklist = new List<int>();

        for (int i=0; i<questions.Count; i++)
        {
            indicesChecklist.Add(questions[i].index);
        }

        while (indicesChecklist.Contains(q.index))
        {
            q.index++;
        }

        //add it to the list
        questions.Add(q);
    }

    //Remove a question from the list, checking the Question.index value
    public void DeleteQuestion(int index)
    {
        for (int i = 0; i < questions.Count; i++)
        {
            if (questions[i].index == index)
                questions.RemoveAt(i);
        }
    }

    //Save the list to file
    public void Save()
    {
        loadedList = this;
        json = JsonUtility.ToJson(loadedList, true);
        File.WriteAllText(Application.persistentDataPath + fileName, json);
        Debug.Log("Saved!");
    }

    //Load the list from file, create a file if it doesn't exist
    public void Load()
    {
        try
        {
            json = File.ReadAllText(Application.persistentDataPath + fileName);
            loadedList = JsonUtility.FromJson<DataList>(json);
            Debug.Log("Loaded!");
        }
        catch
        {
            Debug.Log("File \"" + fileName + "\" does not exist. Creating new file.");
            Save();
        }
    }

    //Clear the list and delete the file
    public void Clear()
    {
        string dataPath = Application.persistentDataPath + fileName;
        try
        {
            File.Delete(dataPath);
            questions.Clear();
            loadedList = this;
            Debug.Log("Cleared!");
        }
        catch
        {
            Debug.LogError("Clearing failed: File does not exist");
        }
    }
}
