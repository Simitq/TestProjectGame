using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bullet", menuName = "Inventory/New Gun")]
public class Gun : Item
{
    
    
    private void Start() {
        itemType = ItemType.Gun;
    }

}
