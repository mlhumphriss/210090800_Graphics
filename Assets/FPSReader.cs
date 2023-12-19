using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Used by UI in order to display Memory used and FPS on screen
public class FPSReader : MonoBehaviour
{

    public TextMeshProUGUI FPSText;
    public TextMeshProUGUI MemText;
    //variables used to calculate fps and as hoolder for memory
    private float pollingTime = 1f;
    private float time;
    private int frames;
    private float Memory;

    
    // Update is called once per frame. This per frame is used so that frames++ can accurately count frames
    void Update()
    {
        time += Time.deltaTime;

        frames++;
        //Converts memory read to mb
        float usedMemory = System.GC.GetTotalMemory(false);
        Memory = usedMemory/(1024f *1024f);
        MemText.text = Memory.ToString() + "MB";
        //Takes frame count across a rough period (aimed to be 1 second) to get an FPS, then resets frames count and time for next reading
        if(time >= pollingTime){
            int frameRate = Mathf.RoundToInt(frames/time);
            FPSText.text = frameRate.ToString() + " FPS";

            time -= pollingTime;
            frames = 0;
        }

        
    }
}
