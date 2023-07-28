using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    public Inventory inventory;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                //Debug.Log(hit.transform.name);
                
                if (hit.collider != null)
                {
                    HitCheckObject(hit);
                }
            }

            
        }

        void HitCheckObject(RaycastHit hit)
        {
            IObjectItem clickInterface = hit.transform.gameObject.GetComponent<IObjectItem>();
            if (clickInterface != null)
            {
                Item item = clickInterface.ClickItem();
                inventory.AddItem(item);
            }
        }
    }

 
}
