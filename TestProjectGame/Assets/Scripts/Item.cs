using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public class Item : using UnityEngine;
public enum ItemType{Bullet, Gun};

public class Item : ScriptableObject {
    
    public GameObject itemPrefab;
    public ItemType itemType;
    public Sprite icon;
    public string itemName;
    public int itemCount;
    public int itemMaxCount;


}


