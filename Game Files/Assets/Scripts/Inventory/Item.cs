using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public string name;
    public float value;

    public void PickUp(PlayerMain player)
    {
        player.inventory.items.Add(new ItemSO(name, value));
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        print("yay");   
        if(col.tag == "Player")
        {
            PickUp(col.gameObject.GetComponent<PlayerMain>());
        }
    }

    // public int amount = 1;
    // public ItemSO item;

    // void OnTriggerEnter2D(Collider2D col){
    //     if(col.gameObject.tag == "Player"){
    //         GetItem(this);
    //     }
    // }

    // public void GetItem(Item item){
    //     PlayerInventory inv = FindObjectOfType<PlayerInventory>();
    //     Slot[] slots = inv.slots;

    //     for(int i = 0; i < slots.Length; i++){
    //         Slot s = slots[i];
    //         if(!s.full){
    //             if(s.filled){
    //                 if(s.filled_itemId == item.item.itemId){
    //                     s.filled_amount++;
    //                     Destroy(gameObject);
    //                     return;
    //                 }
    //             }
    //             else if(!s.filled){
    //                 s.filled = true;
    //                 s.filled_itemId = item.item.itemId;
    //                 s.filled_amount = item.amount;
    //                 s.filledItem = item.item;
    //                 Destroy(gameObject);
    //                 return;
    //             }
    //         }
    //     }
    // }
}
