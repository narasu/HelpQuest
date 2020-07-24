using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExtendedButton : MonoBehaviour
{
    public Target target;

    public void OpenLocalList()
    {
        DataManager.Instance.OpenList(ListType.Local);
    }
    public void OpenGlobalList()
    {
        DataManager.Instance.OpenList(ListType.Global);
    }

    public void GotoPage()
    {

    }
}
