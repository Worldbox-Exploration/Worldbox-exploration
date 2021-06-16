using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObjects/Item", order = 1)]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public int itemId;
    public int maxCount;
    public Sprite image;
}
