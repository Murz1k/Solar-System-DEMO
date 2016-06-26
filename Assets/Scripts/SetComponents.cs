using UnityEngine;
using System.Collections;
using System.IO;
public class SetComponents : MonoBehaviour
{
    private float speed;
    private float size;
    private float x;
    private string planetName;
    private GameObject planet;
    private TextMesh text;
    void Start()
    {
        planetName = gameObject.name;
        ///select planet from Planets where planet.name = planetName
        string[] file = File.ReadAllLines("Данные.txt");
        foreach(string line in file)
        {
            string[] l = line.Split(' ');
            if(l[0]==planetName)
            {
                speed = float.Parse(l[1]);
                size = float.Parse(l[2]);
                x = float.Parse(l[3]);
                break;
            }
        }
        planet = GameObject.Find(planetName + "_Object");
        planet.transform.localScale = new Vector3(size, size, size);
        planet.transform.localPosition = new Vector3(0, 0, 0);
        transform.position = new Vector3(x, 0, 0);

        GameObject cam = GameObject.Find(planetName+"_Camera");
        cam.transform.eulerAngles = new Vector3(20, 270, 0);
        cam.transform.localPosition = new Vector3(size*1.5f, size, 0);

        GameObject textMesh = GameObject.Find(planetName + "_Text");
        textMesh.transform.localPosition = new Vector3(0, size*0.75f, 0);
        textMesh.transform.eulerAngles = new Vector3(0,270,0);
        text = textMesh.GetComponent<TextMesh>();
        text.text = planetName;
        text.anchor = TextAnchor.MiddleCenter;
    }
    public void Update()
    {
        transform.RotateAround(transform.root.transform.localPosition, Vector3.down, Time.deltaTime * speed);
        planet.transform.Rotate(Vector3.down, Time.deltaTime * speed);
    }
}

