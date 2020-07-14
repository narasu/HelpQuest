using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public enum UserType { Local, Other }

public class SubmitField : MonoBehaviour
{
    public EntryType entryType;
    public UserType userType;

    [HideInInspector] public TMP_InputField inputField;
    [HideInInspector] public Button submitButton;
    [HideInInspector] public User user;

    private void Awake()
    {
        inputField = GetComponentInChildren<TMP_InputField>();
        submitButton = GetComponentInChildren<Button>();

        if (userType == UserType.Local)
            user = LocalUser.Instance;
        else if (userType == UserType.Other)
            user = new User();
    }

    

    public void OnClick()
    {
        try
        {
            DataManager.Instance.SubmitEntry(entryType, inputField.text, user);
            inputField.text = "";
        }
        catch
        {
            Debug.LogError("Something went wrong while submitting your entry!");
        }
        
    }
}
