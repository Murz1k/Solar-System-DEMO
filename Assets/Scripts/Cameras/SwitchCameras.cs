using UnityEngine;
using System.Collections;

public class SwitchCameras : MonoBehaviour
{
    public Camera Sun;
    public Camera Free;
    public Camera Earth;
    public Camera Jupiter;
    public Camera Mars;
    public Camera Mercury;
    public Camera Neptune;
    public Camera Pluto;
    public Camera Saturn;
    public Camera Uranus;
    public Camera Venus;
    public Camera Moon;

    public void NewCam(Camera cam)
    {
        Free.enabled = false;
        Sun.enabled = false;
        Earth.enabled = false;
        Jupiter.enabled = false;
        Mars.enabled = false;
        Mercury.enabled = false;
        Neptune.enabled = false;
        Pluto.enabled = false;
        Saturn.enabled = false;
        Uranus.enabled = false;
        Venus.enabled = false;
        Moon.enabled = false;
        cam.enabled = true;
    }
    void Start()
    {
        NewCam(Free);
    }
    void OnGUI()
    {
        if(GUI.Button(new Rect(10,10,100,20),"Free"))
        {
            NewCam(Free);
        }
        if (GUI.Button(new Rect(10, 30, 100, 20), "Sun"))
        {
            NewCam(Sun);
        }
        if (GUI.Button(new Rect(10, 50, 100, 20), "Earth"))
        {
            NewCam(Earth);
        }
        if (GUI.Button(new Rect(10, 70, 100, 20), "Jupiter"))
        {
            NewCam(Jupiter);
        }
        if (GUI.Button(new Rect(10, 90, 100, 20), "Mars"))
        {
            NewCam(Mars);
        }
        if (GUI.Button(new Rect(10, 110, 100, 20), "Mercury"))
        {
            NewCam(Mercury);
        }
        if (GUI.Button(new Rect(10, 130, 100, 20), "Neptune"))
        {
            NewCam(Neptune);
        }
        if (GUI.Button(new Rect(10, 150, 100, 20), "Pluto"))
        {
            NewCam(Pluto);
        }
        if (GUI.Button(new Rect(10, 170, 100, 20), "Saturn"))
        {
            NewCam(Saturn);
        }
        if (GUI.Button(new Rect(10, 190, 100, 20), "Uranus"))
        {
            NewCam(Uranus);
        }
        if (GUI.Button(new Rect(10, 210, 100, 20), "Venus"))
        {
            NewCam(Venus);
        }
        if (GUI.Button(new Rect(10, 230, 100, 20), "Moon"))
        {
            NewCam(Moon);
        }
    }
 

}
