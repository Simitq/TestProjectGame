using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public Item item;
    public int amount;
    public bool isEmpty = true;
    public GameObject iconGO;
    public TMP_Text itemCount;
    public GameObject deleteBut;
    public bool isActiveDel = false;

    private void Awake() {
        iconGO = transform.GetChild(0).gameObject;
        itemCount = transform.GetChild(1).GetComponent<TMP_Text>();
        deleteBut = transform.GetChild(2).gameObject;
    }

    public void SetIcon(Sprite _icon)
    {
        iconGO.GetComponent<Image>().color = new Color(1,1,1,1);
        iconGO.GetComponent<Image>().sprite = _icon;
        
    }
    public void SetCount()
    {
        if(amount == 1)
        {
            itemCount.text = "";
            return;
        }
        itemCount.text = amount.ToString();
        if(amount == 0)
        {
            RemoveItem();
        }
    }

    public void DeleteButton()
    {
        if(isActiveDel == false && !isEmpty)
        {
            deleteBut.SetActive(true);
            isActiveDel = true;
            return;
        }
        if(isActiveDel)
        {
            deleteBut.SetActive(false);
            isActiveDel = false;
        }
        
    }
    public void RemoveItem()
    {
        item = null;
        itemCount.text = "";
        iconGO.GetComponent<Image>().sprite = null;
        deleteBut.SetActive(false);
        isActiveDel = false;
        isEmpty = true;
    }

}
