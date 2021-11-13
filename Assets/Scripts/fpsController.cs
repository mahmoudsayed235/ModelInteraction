using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fpsController : MonoBehaviour
{
    public Text fpsText;
    private int FramesPerSec;
    private float frequency = 1.0f;
    private string fps;



    void Start()
    {
        StartCoroutine(FPS());
    }
    /*
     * calcualte the FPS and print the value on Text UI
     */
    private IEnumerator FPS()
    {
        while (true)
        {
            // Capture frame-per-second
            int lastFrameCount = Time.frameCount;
            float lastTime = Time.realtimeSinceStartup;
            yield return new WaitForSeconds(frequency);
            float timeSpan = Time.realtimeSinceStartup - lastTime;
            FramesPerSec = Time.frameCount - lastFrameCount;

            // Display it

            fps = string.Format("FPS: {0}", Mathf.RoundToInt(FramesPerSec / timeSpan));
            fpsText.text = fps;
        }
    }


   
}