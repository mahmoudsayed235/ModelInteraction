using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loaderController : MonoBehaviour
{
    private Transform initializedTransofrm;
    /*
     * there is an issue with the attached Model 'ArgumentException: JSON parse error: Invalid value.'
     * so I use url of the model in the GLTFast documentation
    */

    public string url= "https://raw.githubusercontent.com/KhronosGroup/glTF-Sample-Models/master/2.0/Duck/glTF/Duck.gltf";
    /*
    * download model using url on Awake function 
    * */

    private void Awake()
    {
        var gltf = gameObject.AddComponent<GLTFast.GltfAsset>();
        gltf.url = url;
    }
    /*
    * reset the model to the initial state
    * 
    * */
    public void Reset()
    {
        transform.rotation = Quaternion.identity;

    }

    
}
