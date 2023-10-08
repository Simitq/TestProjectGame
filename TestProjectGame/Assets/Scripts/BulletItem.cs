using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bullet", menuName = "Inventory/New Bullet")]
public class BulletItem : Item
{
    private void Start() {
        itemType = ItemType.Bullet;
    }
}
