using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{

    public List<ItemSO> items = new List<ItemSO>();

    // public Slot[] slots;

    // public GameObject inventoryPanel;

    // public GameObject dragImg;

    // public Item sample1;
    // public Item sample2;

    // bool invOpen = false;
    // void Update(){
    //     if(Input.GetKeyDown(KeyCode.E)){
    //         invOpen = !invOpen;
    //         inventoryPanel.SetActive(invOpen);
    //     }

    //     if(Input.GetKeyDown(KeyCode.R)){
    //         GetItem(sample1);
    //     }
    //     if(Input.GetKeyDown(KeyCode.T)){
    //         GetItem(sample2);
    //     }

    //     dragImg.transform.position = Input.mousePosition;
    // }

    // public void GetItem(Item item){
    //     for(int i = 0; i < slots.Length; i++){
    //         Slot s = slots[i];
    //         if(!s.full){
    //             if(s.filled){
    //                 if(s.filled_itemId == item.item.itemId){
    //                     s.filled_amount++;
    //                     return;
    //                 }
    //             }
    //             else if(!s.filled){
    //                 s.filled = true;
    //                 s.filled_itemId = item.item.itemId;
    //                 s.filled_amount = item.amount;
    //                 s.filledItem = item.item;
    //                 return;
    //             }
    //         }
    //     }
    // }
}
