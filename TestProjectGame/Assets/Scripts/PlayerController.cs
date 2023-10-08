using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2d;
    [SerializeField] private FixedJoystick _joystick;
    

    [SerializeField] private float _movespeed;
    [SerializeField] private Animator _anim;
    
    public bool facingRight = true;

    private int health = 100;
    public List<InventorySlot> slots = new List<InventorySlot>();
    public Transform inventoryPanel;
    private void Start() {
        
        _anim = GetComponent<Animator>();
        for(int i = 0; i < inventoryPanel.childCount; i++)
        {
            slots.Add(inventoryPanel.GetChild(i).GetComponent<InventorySlot>());
        }
        
        
    }

    private void Update() {
        if(_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            _anim.SetBool("isRunning", true);
        }
        else 
        {
            _anim.SetBool("isRunning", false);
        }
        

    }
    private void FixedUpdate() 
    {

        
        _rigidbody2d.velocity = new Vector2(_joystick.Horizontal * _movespeed, _joystick.Vertical * _movespeed);
        
        if(!facingRight && _joystick.Horizontal > 0)
        {
            Flip();
        }
        else if(facingRight && _joystick.Horizontal < 0)
        {
            Flip();
        }
        
        
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void ChangeHealth(int healthValue)
    {
        health += healthValue;
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
        
        if(other.gameObject.tag == "Item")
        {
            foreach(InventorySlot slot in slots)
        {
            if(slot.item == other.gameObject.GetComponent<ItemManager>().item)
            {
                if(slot.amount + other.gameObject.GetComponent<ItemManager>().amount <= other.gameObject.GetComponent<ItemManager>().item.itemMaxCount)
                {
                slot.amount += other.gameObject.GetComponent<ItemManager>().amount;
                slot.SetCount();
                Destroy(other.gameObject);
                return;
                }
                break;
            }
        }
        foreach(InventorySlot slot in slots)
        {
            
            if(slot.isEmpty == true)
            {
                slot.item = other.gameObject.GetComponent<ItemManager>().item;
                slot.amount = other.gameObject.GetComponent<ItemManager>().amount;
                slot.SetIcon(other.gameObject.GetComponent<ItemManager>().item.icon);

                slot.isEmpty = false;
                slot.SetCount();
                Destroy(other.gameObject);
                return;
            }
        }
            
        }
        
    }
    
    
}
