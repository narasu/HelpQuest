using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public enum GameStateType { Home, Wardrobe, Mailbox, List, Read, Write }

public abstract class GameState
{
    protected GameFSM owner;
    protected GameManager gameManager;

    public void Initialize(GameFSM owner)
    {
        this.owner = owner;
        gameManager = owner.owner;
    }
    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();
}
//home screen
public class HomeState : GameState
{
    public override void Enter()
    {
        
    }
    public override void Update()
    {

    }
    public override void Exit()
    {

    }
}
//character customization
public class WardrobeState : GameState
{
    public override void Enter()
    {

    }
    public override void Update()
    {

    }
    public override void Exit()
    {

    }
}
//notifications
public class MailboxState : GameState
{
    public override void Enter()
    {

    }
    public override void Update()
    {

    }
    public override void Exit()
    {

    }
}
//view list of questions
public class ListState : GameState
{
    //give parameters local/global
    public override void Enter()
    {

    }
    public override void Update()
    {

    }
    public override void Exit()
    {

    }
}
//open question and view answers
public class ReadState : GameState
{
    //give parameters local/global
    public override void Enter()
    {

    }
    public override void Update()
    {

    }
    public override void Exit()
    {

    }
}
//write question / answer
public class WriteState : GameState
{
    //give parameters question/answer
    public override void Enter()
    {

    }
    public override void Update()
    {

    }
    public override void Exit()
    {

    }
}