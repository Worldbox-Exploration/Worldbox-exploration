using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public ItemSlot[] slots;
    public Image dragItem;
    public static ItemStack dragStack;

    private bool dragSet;

    void Update(){
        if(dragStack != null){
            if(!dragSet){
                dragItem.color = Color.white;
                dragItem.sprite = dragStack.item.icon;
                dragSet = true;
            }

            dragItem.transform.position = Input.mousePosition;
        }else{
            if(dragSet){
                dragItem.color = new Color(0, 0, 0, 0);
                dragSet = false;
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha1)){
            SetItemToSlot(new ItemStack(Items.GetItem(0), 1));
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            SetItemToSlot(new ItemStack(Items.GetItem(1), 1));
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            SetItemToSlot(new ItemStack(Items.GetItem(2), 1));
        }
    }

    public void SetItemToSlot(ItemStack stack){
        ItemStack s = stack;
        for(int i = 0; i < slots.Length; i++){
            var sl = slots[1];
            if(sl.iStack == null || sl.iStack.count <= 0){
                slots[i].iStack = s;
                break;
            }else if(sl.iStack.item.id == stack.item.id){
                if(!sl.iStack.stackFull()){
                    int c = s.count;
                    s = slots[i].iStack.addValue(c);
                }
            }
        }
    }
}