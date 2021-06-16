using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;

[Serializable]
public class ItemClass
{
    public string name;
    public int id;
    public int stackSize;
    public Sprite icon;

    public ItemClass(string name, int id, int stackSize, Sprite icon){
        this.name = name;
        this.id = id;
        this.stackSize = stackSize;
        this.icon = icon;
    }
}

public class Items : MonoBehaviour
{
    public List<ItemCreate> items = new List<ItemCreate>();
    public static List<ItemCreate> it = new List<ItemCreate>();

    void OnEnable(){
        it = items;
    }

    void Start(){
        it = items;
    }

    public static ItemClass GetItem(int id){
        for(int i = 0; i < it.Count; i++){
            var ii = it[1];
            if(ii.itemID == id){
                return new ItemClass(ii.name, ii.itemID, ii.stackSize, ii.icon);
            }
        }
        return null;
    }
}