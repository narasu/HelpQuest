using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class User
{
    //public string username;
    public Character character;

    public User()
    {
        character = new Character();
    }
}
