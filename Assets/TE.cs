using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TE : MonoBehaviour
{
    bool rotating;
    float rotateSpeed = 30.0f;
    Vector3 mousePos, offset, rotation;

    void OnMouseDown()
    {
        rotating = true;

        mousePos = Input.mousePosition;
    }

    void OnMouseUp()
    {
        rotating = false;
    }

    void Update()
    {
        if (rotating)
        {
            offset = (Input.mousePosition - mousePos);

            rotation.y = -(offset.x + offset.y) * Time.deltaTime * rotateSpeed;

            transform.Rotate(rotation);

            mousePos = Input.mousePosition;
        }
    }
}