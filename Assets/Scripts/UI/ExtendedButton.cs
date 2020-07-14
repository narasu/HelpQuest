using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Target { Home, Wardrobe, Mailbox, Ask, Answer, MyQuestions }

public class ExtendedButton : MonoBehaviour
{
    //public Target target;

    public void OpenLocalList()
    {
        DataManager.Instance.OpenList(ListType.Local);
    }
    public void OpenGlobalList()
    {
        DataManager.Instance.OpenList(ListType.Global);
    }

}
