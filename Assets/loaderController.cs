using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loaderController : MonoBehaviour
{
    public string url= "https://raw.githubusercontent.com/KhronosGroup/glTF-Sample-Models/master/2.0/Duck/glTF/Duck.gltf";
    private void Awake()
    {
        var gltf = gameObject.AddComponent<GLTFast.GltfAsset>();
        gltf.url = url;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
