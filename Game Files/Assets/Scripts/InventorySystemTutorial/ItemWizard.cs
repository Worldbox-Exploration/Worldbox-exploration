using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ItemWizard : ScriptableWizard
{
    public string itemName;
    public int itemID;
    public int stackSize;
    public Sprite icon;

    [MenuItem("Assets/Items/Item")]
    public static void CreateItem(){
        ScriptableWizard.CreateWindow<ItemWizard>();
    }

    private void OnWizardCreate(){
        ItemCreate i = ScriptableObject.CreateInstance<ItemCreate>();
        i.itemName = itemName;
        i.itemID = itemID;
        i.stackSize = stackSize;
        i.icon = icon;

        AssetDatabase.CreateAsset(i, "Assets/ScriptableObjects/Items/" + itemID + "_" + itemName + "_item" + ".asset");
        AssetDatabase.Refresh();
    }
}
