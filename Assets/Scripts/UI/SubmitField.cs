using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SubmitField : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button submitButton;

    private void Awake()
    {
        inputField = GetComponentInChildren<TMP_InputField>();
    }
}
