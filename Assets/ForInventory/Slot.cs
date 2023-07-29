using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Image image;
    public TextMeshProUGUI text;
    //public int theNumberOf = 1;

    void Update()
    {
        // && item.amount > 1
        if (_item != null)
        {
            text.text = item.amount.ToString();
        }
        else
        {
            text.text = null;
        }
        /*if(theNumberOf != 0 && theNumberOf != 1)
        {
            text.text = "" + theNumberOf;
        }*/
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(_item != null)
        {
            if(GameData.objectShowed != null)
            {
                Destroy(GameData.objectShowed);
            }
            GameData.objectShowed = Instantiate<GameObject>(item.gameObject, new Vector3(17.7099991f, 5.07999992f, -1.2294817f), Quaternion.identity);

        }
        
    }

    private Item _item;
    public Item item
    { get { return _item; }
        set
        {
            _item = value;
            if(_item != null)
            {
                image.sprite = item.itemImage;
                image.color = new Color(1, 1, 1, 1);

            }
            else
            {
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }


}
