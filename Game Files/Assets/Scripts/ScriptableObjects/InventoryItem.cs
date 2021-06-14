using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/InventoryItem", order = 1)]
public class InventoryItem : ScriptableObject
{
    public string id;

    public enum type{ placeable, consumable, tool, craftable }
    public type Type;

    public Sprite slotImg;

    public bool stackable;
}
