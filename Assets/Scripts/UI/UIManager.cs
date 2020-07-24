using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum Target { Home, Wardrobe, Mailbox, Ask, Answer, MyQuestions }

public class UIManager : MonoBehaviour
{
    private Dictionary<Target, GameObject> targetObjects;
    [SerializeField] private GameObject[] screens;

    private void Awake()
    {
        targetObjects = new Dictionary<Target, GameObject>();
    }

    public void Open(Target target)
    {

    }
}