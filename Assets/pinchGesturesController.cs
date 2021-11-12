using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinchGesturesController : MonoBehaviour
{
    public float zoomSpeed = 0.001f;
    private void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch pointZero = Input.GetTouch(0);
            Touch pointOne = Input.GetTouch(1);

            Vector2 pointZeroPrevious = pointZero.position - pointZero.deltaPosition;
            Vector2 pointOnePrevious = pointOne.position - pointOne.deltaPosition;

            float touchDeltaPrevious = (pointZeroPrevious - pointOnePrevious).magnitude;
            float touchDelta = (pointZero.position - pointOne.position).magnitude;

            float touchMagDelta = touchDeltaPrevious - touchDelta;

            if (Camera.main.orthographic)
            {
                Camera.main.orthographicSize += touchMagDelta * zoomSpeed;
                Camera.main.orthographicSize = Mathf.Max(Camera.main.orthographicSize,.1f) ;

            }
            else
            {
                Camera.main.fieldOfView += touchMagDelta * zoomSpeed;
                Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, .1f,100f);

            }
        }
    }

}
