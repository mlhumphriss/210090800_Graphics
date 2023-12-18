using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FPSReader : MonoBehaviour
{

    public TextMeshProUGUI FPSText;
    public TextMeshProUGUI MemText;

    private float pollingTime = 1f;
    private float time;
    private int frames;
    private float Memory;

    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        frames++;

        float usedMemory = System.GC.GetTotalMemory(false);
        Memory = usedMemory/(1024f *1024f);
        MemText.text = Memory.ToString() + "MB";

        if(time >= pollingTime){
            int frameRate = Mathf.RoundToInt(frames/time);
            FPSText.text = frameRate.ToString() + " FPS";

            time -= pollingTime;
            frames = 0;
        }

        
    }
}
