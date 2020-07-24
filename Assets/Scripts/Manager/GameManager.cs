using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    private GameFSM fsm;

    public GameObject homeObject;
    public GameObject wardrobeObject;
    public GameObject mailboxObject;
    public GameObject listObject;
    public GameObject readObject;
    public GameObject writeObject;

    private void Awake()
    {
        fsm = new GameFSM();
        fsm.Initialize();

        instance = this;
    }

    private void Start()
    {
        fsm.GotoState(GameStateType.Home);
    }

    private void Update()
    {
        fsm.UpdateState();
    }
}
