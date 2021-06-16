using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [HideInInspector]
    public bool filled;
    [HideInInspector]
    public bool full;
    [HideInInspector]
    public int filled_itemId;
    [HideInInspector]
    public int filled_amount;

    [HideInInspector]
    public ItemSO filledItem;

    [HideInInspector]
    public bool mouseOver;

    private Image img;
    private Text txt;

    void Start(){
        img = transform.GetComponentInChildren<Image>();
        txt = GetComponentInChildren<Text>();
    }

    void Update(){
        txt.text = filled_amount.ToString();
        if(filled_amount == 1 || filled_amount == 0) txt.text = "";

        if(filledItem != null){
            Image[] img_ = gameObject.GetComponentsInChildren<Image>();
         
            foreach(Image i in img_){
                if(i.gameObject.transform.parent != null){
                    img = i;
                }
            }
            img.sprite = filledItem.image;
        }

        if(!filled) return;
        if(filled_amount >= filledItem.maxCount){
            full = true;
        }else{
            full = false;
        }

        if(!filled){
            filled_amount = 0;
            filled_itemId = 0;
            filledItem = null;
            full = false;
            img.sprite = null;
        }
    }

    void OnMouseOver(){
        mouseOver = true;
    }
    void OnMouseExit(){
        mouseOver = false;
    }
}
