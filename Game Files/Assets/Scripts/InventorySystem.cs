using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public List<StoredItem> storedItems = new List<StoredItem>();
    public List<InventoryItem> items = new List<InventoryItem>();
    private int maxItems = 9;
    private int itemsStored;

    void Update(){
        if(Input.GetKeyDown(KeyCode.E)){

        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Item"){
            InventoryItem i = col.gameObject.GetComponent<Item>().inventoryItem;
            if(itemsStored <= maxItems){
                Destroy(col.gameObject);
                if(storedItems.Count == 0){
                    StoredItem s = new StoredItem();
                    s.itemType = i;
                    storedItems.Add(s);
                }else{
                    foreach(StoredItem si in storedItems){
                        if(si.itemType.id == i.id){
                            if(!i.stackable){
                                StoredItem sii = new StoredItem();
                                sii.itemType = i;
                                storedItems.Add(sii);
                            }else{
                                si.amount++;
                            }
                        }else{
                            //add item
                        }
                    }
                }
            }else{

            }
        }
    }
}

[System.Serializable]
public class StoredItem
{
    public InventoryItem itemType;
    public int amount = 1;
}
