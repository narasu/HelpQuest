using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFSM
{
    public GameManager owner;

    private Dictionary<GameStateType, GameState> states;

    public GameStateType CurrentStateType { get; private set; }
    public GameStateType PreviousStateType { get; private set; }

    private GameState currentState;
    private GameState previousState;

    public void Initialize()
    {
        states = new Dictionary<GameStateType, GameState>();

        states.Add(GameStateType.Home, new HomeState());
        states.Add(GameStateType.Wardrobe, new WardrobeState());
        states.Add(GameStateType.Mailbox, new MailboxState());
        states.Add(GameStateType.List, new ListState());
        states.Add(GameStateType.Read, new ReadState());
        states.Add(GameStateType.Write, new WriteState());
    }

    public void UpdateState()
    {
        currentState?.Update();
    }

    public void GotoState(GameStateType key)
    {
        if (!states.ContainsKey(key))
        {
            return;
        }

        currentState?.Exit();

        previousState = currentState;
        PreviousStateType = CurrentStateType;

        CurrentStateType = key;
        currentState = states[CurrentStateType];

        currentState.Enter();
    }

    public GameState GetState(GameStateType type)
    {
        if (!states.ContainsKey(type))
        {
            return null;
        }
        return states[type];
    }
}
