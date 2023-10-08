using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    public GameObject bullet;
    public Transform startPosShoot;
    public List<InventorySlot> slots = new List<InventorySlot>();
    public void MetShoot()
    {
        foreach(InventorySlot slot in slots)
        if(slot.amount > 0 && slot.item.itemName == "Bullet")
        {
            Instantiate(bullet, startPosShoot.position, Quaternion.identity);
            slot.amount -= 1;
            slot.SetCount();
            break;
        }
        
        
    }
}
