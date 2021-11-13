using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLoader : MonoBehaviour
{
    /*
     * rotate the loader image according to Z axis
     */
    void Update()
    {
        transform.RotateAround(new Vector3(0,0,1), .01f);

    }
}
