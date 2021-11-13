using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loaderController : MonoBehaviour
{
    public GameObject loader;
    public GameObject popup;
    public string url= "https://raw.githubusercontent.com/nandiniiys/3D-Visualization-of-a-Building/main/McCormackBuildingFiles/Mck04/Mck04.gltf";
    /*
    * check internet connection
    * */
    GLTFast.GltfAsset gltf;
    private void Awake()
    {
        checkConnection();
       
        

    }

    /*
    * download model using url on Awake function if there is internet connection
    * */
    private void downloadModel()
    {
        gltf = gameObject.AddComponent<GLTFast.GltfAsset>();
        gltf.url = url;
        hideLoader();


    }



    /*
     * function to check internet connection
     * 
     */
    public void checkConnection()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            popup.SetActive(true);
            return ;
        }
        popup.SetActive(false);
        downloadModel();
    }
    /*
     * function to hide the loader 
     * it make a check condition every 0.2 part of second and stop when the download finished
     */
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
