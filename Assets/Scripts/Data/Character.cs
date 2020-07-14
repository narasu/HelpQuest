using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterItemType { Hair, Top, Bottom, Shoes }

[Serializable]
public class Character
{
    public int hair;
    public int top;
    public int bottom;
    public int shoes;

    private Dictionary<CharacterItemType, int> currentItems;
    private Dictionary<CharacterItemType, string> itemPaths;

    public Character()
    {
        hair = 1;
        top = 2;
        bottom = 0;
        shoes = 1;

        currentItems = new Dictionary<CharacterItemType, int>()
        {
            { CharacterItemType.Hair, hair },
            { CharacterItemType.Top, top },
            { CharacterItemType.Bottom, bottom },
            { CharacterItemType.Shoes, shoes }
        };

        itemPaths = new Dictionary<CharacterItemType, string>()
        {
            { CharacterItemType.Hair, "Hair" },
            { CharacterItemType.Top, "Top" },
            { CharacterItemType.Bottom, "Bottom" },
            { CharacterItemType.Shoes, "Shoes" }
        };
    }

    public Sprite DisplayItem(CharacterItemType itemType)
    {
        currentItems.TryGetValue(itemType, out int t);
        itemPaths.TryGetValue(itemType, out string p);

        string path = "Character/" + p + t.ToString();

        try
        {
            return (Sprite)Resources.Load(path);
        }
        catch
        {
            Debug.LogError("File path \"" + path + "\"does not exist!");
            return null;
        }
    }
}
