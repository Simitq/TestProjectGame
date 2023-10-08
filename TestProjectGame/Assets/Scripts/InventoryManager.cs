using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject UIPanel;
    private bool isOpen;
    

    private void Start() 
    {
        
    UIPanel.SetActive(false);
    }
    public void InventoryOC()
    {
        isOpen = !isOpen;
        if(isOpen)
        {
            UIPanel.SetActive(true);
        }
        else
        {
            UIPanel.SetActive(false);
        }
    }

    
}
