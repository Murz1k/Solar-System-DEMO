using UnityEngine;
using System.Collections;

public class SwitchCameras : MonoBehaviour
{
    private Camera[] Cameras;
    private Rect[] rects;
    private string[] names;
    void Start()
    {
        Cameras = GameObject.FindObjectsOfType<Camera>();
        rects = new Rect[Cameras.Length];
        names = new string[Cameras.Length];
        for (int index = 0; index < Cameras.Length; index++)
        {
            rects[index]= new Rect(10, 10 + 20 * index, 100, 20);
            names[index] = Cameras[index].name.Split('_')[0];
        }
        foreach (var camera in Cameras)
        {
            if (camera.name.Split('_')[0] != "Free")
                camera.enabled = false;
        }
    }
    void OnGUI()
    {
        for (int index = 0; index < Cameras.Length; index++)
        {
            if (GUI.Button(rects[index], names[index]))
            {
                foreach(var camera in Cameras)
                {
                    if (camera != Cameras[index])
                       camera.enabled = false;
                }
                Cameras[index].enabled = true;
            }
        }
    }
}
