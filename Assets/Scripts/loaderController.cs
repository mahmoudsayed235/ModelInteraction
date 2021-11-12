using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loaderController : MonoBehaviour
{
    public GameObject loader;
    /*
     * there is an issue with the attached Model 'ArgumentException: JSON parse error: Invalid value.'
     * so I use url of the model in the GLTFast documentation
    */

    public string url= "https://raw.githubusercontent.com/KhronosGroup/glTF-Sample-Models/master/2.0/Duck/glTF/Duck.gltf";
    /*
    * download model using url on Awake function 
    * */
    GLTFast.GltfAsset gltf;
    private void Awake()
    {
        gltf = gameObject.AddComponent<GLTFast.GltfAsset>();
        gltf.url = url;
        hideLoader();
        

    }
    void hideLoader()
    {
        if (gltf.isDone)
        {
            loader.SetActive(false);
            return;
        }
        Invoke("hideLoader", 0.2f);
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
