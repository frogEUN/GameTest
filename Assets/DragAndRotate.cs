using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndRotate : MonoBehaviour, IPointerClickHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler
{
    bool rotating;
    public float rotateSpeed = 30f;
    Vector3 mousePos, offset, rotation;
    private bool drag = false;
    private bool click = false;

    public void OnBeginDrag(PointerEventData eventData)
    {
        click = true;
    }



    void Update()
    {
        if (Input.GetMouseButton(0) && drag && click)
        {
            offset = (-Input.mousePosition + mousePos);
            rotation.x = offset.y * Time.deltaTime * rotateSpeed;
            rotation.y = offset.x * Time.deltaTime * rotateSpeed;
            GameData.objectShowed.transform.Rotate(rotation, Space.World);

        }
        mousePos = Input.mousePosition;


    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Click");
    }

    public void OnDrag(PointerEventData eventData)
    {
        
        //Debug.Log("Drag");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Enter");
        drag = true;
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Exit");
        drag = false;
        click = false;
    }
}
