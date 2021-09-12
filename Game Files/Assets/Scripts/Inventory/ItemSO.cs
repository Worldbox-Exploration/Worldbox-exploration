using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemSO
{
    public string name;
    public float value;

    public ItemSO(string name, float value)
    {
        this.name = name;
        this.value = value;
    }
}
