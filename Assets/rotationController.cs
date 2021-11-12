using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationController : MonoBehaviour
{
    public float rotateSpeed = .01f;
    private Quaternion rotation;

    [System.Obsolete]
    private void Update()
    {
        if (Input.touchCount ==1)
        {
            Touch pointZero = Input.GetTouch(0);
          
            Vector2 pointZeroPrevious = pointZero.position - pointZero.deltaPosition;
            if (pointZero.phase == TouchPhase.Moved)
            {
                rotation = Quaternion.Euler(pointZero.deltaPosition.y, pointZero.deltaPosition.x, 0f);
                //transform.rotation = rotation * transform.rotation;    
                transform.RotateAround(Vector3.up, -pointZero.deltaPosition.x*rotateSpeed);
                transform.RotateAround(Vector3.right, pointZero.deltaPosition.y * rotateSpeed);
            }           
        }
    }

}

