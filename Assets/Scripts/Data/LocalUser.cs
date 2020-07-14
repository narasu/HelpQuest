using UnityEngine;
using System.Collections;
using System;

[Serializable]
// the user who is using this app
public class LocalUser : User
{
    private static LocalUser instance;

    public static LocalUser Instance
    {
        get
        {
            return instance;
        }
    }

    public LocalUser()
    {
        instance = this;
    }
}
