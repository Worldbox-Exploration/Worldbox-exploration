using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemStack
{
    public ItemClass item;
    public int stackSize;
    public int count;

    public ItemStack(ItemClass i, int size){
        item = i;
        stackSize = i.stackSize;

        if(size < stackSize){
            count = size;
        }
    }

    public bool stackFull(){
        if(count >= stackSize){
            return true;
        }else{
            return false;
        }
    }

    public ItemStack addValue(int value){
        if(item != null){
            count += value;

            if(count > stackSize){
                int i = count - stackSize;
                return new ItemStack(item, i);
            }
        }

        return null;
    }

    public int deleteValue(int size){
        if(item != null){
            if(count > 1){
                count -= size;

                if(count < 0){
                    return count * -1;
                }
            }
        }

        return 0;
    }
}