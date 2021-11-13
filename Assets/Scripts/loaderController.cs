using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loaderController : MonoBehaviour
{
    public GameObject loader;
    public string url= "https://raw.githubusercontent.com/nandiniiys/3D-Visualization-of-a-Building/main/McCormackBuildingFiles/Mck04/Mck04.gltf";
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
    /*
     * function to hide the load 
     * it make a check condition every 0.2 part of second and stop when the download finished
     */
    void hideLoader()
    {
        if (gltf.isDone)
        {
            loader.SetActive(false);
            var material = gltf.GetMaterial();
            Debug.LogFormat("The first material is called {0}", material.name);

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
