using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [HideInInspector]
    public ItemStack iStack;
    public Sprite defaultImage;
    [HideInInspector]
    public Image icon;
    [HideInInspector]
    public Text valueText;
    
    private bool isSlot, setted;

    void Start(){
        icon = GetComponent<Image>();
        valueText = transform.GetComponentInChildren<Text>();
        icon = transform.GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData){
        isSlot = true;
    }

    public void OnPointerExit(PointerEventData eventData){
        isSlot = false;
    }

    void Update(){
        if(isSlot){
            if(Input.GetMouseButtonDown(0)){
                if(iStack != null && iStack.count > 0){
                    Inventory.dragStack = iStack;
                    iStack = null;
                }
            }else if(Input.GetMouseButtonUp(0)){
                if(Inventory.dragStack != null){
                    if(iStack == null){
                        iStack = Inventory.dragStack;
                        Inventory.dragStack = null;
                    }else if(iStack.count <= 0){
                        iStack = Inventory.dragStack;
                        Inventory.dragStack = null;
                    }else{
                        if(Inventory.dragStack.item.id == iStack.item.id){
                            var i = Inventory.dragStack.count;
                            Inventory.dragStack = iStack.addValue(i);
                        }
                    }
                }
            }
        }

        if(iStack != null && iStack.count > 0){
            if(iStack.item.icon != null && !setted){
                icon.sprite = iStack.item.icon;
                setted = true;
            }

            if(!valueText.text.Equals(iStack.count + "")){
                valueText.text = iStack.count + "";
            }
        }else{
            if(setted){
                icon.sprite = defaultImage;
                valueText.text = "";
                setted = false;
            }
        }
    }
}