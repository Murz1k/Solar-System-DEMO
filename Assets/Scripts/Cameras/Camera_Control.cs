using UnityEngine;
using System.Collections;

public class Camera_Control : MonoBehaviour
{
    private GameObject Camera;
    public uint speed = 1;

    public GameObject go;
    private Vector3 MousePos;
    private float MyAngle = 0F;
    /*public Moon moon;
    public Earth earth;
    public Jupiter jupiter;
    public Mars mars;
    public Mercury mercury;
    public Neptune neptune;
    public Pluto pluto;
    public Saturn saturn;
    public Uranus uranus;
    public Venus venus;*/
    private bool size = false;
    int max = 400;
    void Start()
    {
        Camera = (GameObject)this.gameObject;
    }
    private Vector3 startMouse { get; set; }
    void Update()
    {
        /*if (size == true)
        {
            scale(moon, max);
            scale(jupiter, max);
            scale(earth, max);
            scale(mars, max);
            scale(mercury, max);
            scale(neptune, max);
            scale(pluto, max);
            scale(saturn, max);
            scale(uranus, max);
            scale(venus, max);
        }
        else
        {
            scale(moon, moon.size);
        }*/
        if (Input.GetKey(KeyCode.W))
        {
            Camera.transform.position += Camera.transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Camera.transform.position -= Camera.transform.right * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Camera.transform.position += Camera.transform.right * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Camera.transform.position -= Camera.transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Camera.transform.position += Camera.transform.up * speed;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Camera.transform.position -= Camera.transform.up * speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Camera.transform.Rotate(Vector3.left, Time.deltaTime * speed * 2);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Camera.transform.Rotate(Vector3.right, Time.deltaTime * speed * 2);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Camera.transform.Rotate(Vector3.down, Time.deltaTime * speed * 2);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Camera.transform.Rotate(Vector3.up, Time.deltaTime * speed * 2);
        }
        if (Input.GetMouseButton(0))
        {
            MyAngle = 0;
            MousePos = Input.mousePosition;
            // расчитываем угол, как:
            // разница между позицией мышки и центром экрана, делённая на размер экрана
            //  (чем дальше от центра экрана тем сильнее поворот)
            // и умножаем угол на чуствительность из параметров
            MyAngle = Time.deltaTime * 512f * ((MousePos.x - (Screen.width / 2)) / Screen.width);
            Camera.transform.Rotate(Camera.transform.up, MyAngle);
            MyAngle = Time.deltaTime * 512f * ((MousePos.y - (Screen.height / 2)) / Screen.height);
            Camera.transform.Rotate(Camera.transform.right, -MyAngle);
        }
        if (Input.GetMouseButtonUp(0))
        {

        }
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect((Screen.width - 185), (Screen.height - 35), 180, 30), "Speed+"))
        {
                speed += 5;
        }
        if (GUI.Button(new Rect((Screen.width - 365), (Screen.height - 35), 180, 30), "Speed-"))
        {
            if (speed > 5)
                speed -= 5;
        }
        if (GUI.Button(new Rect((Screen.width - 545), (Screen.height - 35), 180, 30), "Size"))
        {
            size = !size;
        }
    }
}

