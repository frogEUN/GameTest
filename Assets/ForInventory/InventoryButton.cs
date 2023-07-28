using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject panel;
    private bool TorF = false;

    private void Start()
    {
        panel.SetActive(false);
    }

    public void OnClick()
    {
        if(TorF)
        {
            panel.SetActive(false);
            TorF = false;
            GameData.inventoryOpen = false;
        }
        else
        {
            panel.SetActive(true);
            TorF = true;
            GameData.inventoryOpen = true;
        }
            
    }
}
