using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Camera_Control : MonoBehaviour
{
    GameObject Camera;
    Vector3 startMouse;
    uint speed = 1;
    private Vector3 MousePos;
    float MyAngle = 0F;
    void Start()
    {
        Camera = (GameObject)this.gameObject;
    }
    void FixedUpdate()
    {
        if(Input.GetButton("Cancel"))
        {
            SceneManager.LoadScene(0);
        }
    }
    void Update()
    {
        Camera.transform.position += new Vector3(Input.GetAxis("HorizontalMove"), 0, Input.GetAxis("VerticalMove")) * speed;
       if (Input.GetKey(KeyCode.Space))
        {
            Camera.transform.position += Camera.transform.up * speed;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Camera.transform.position -= Camera.transform.up * speed;
        }
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    Camera.transform.Rotate(Vector3.left, Time.deltaTime * speed * 2);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    Camera.transform.Rotate(Vector3.right, Time.deltaTime * speed * 2);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Camera.transform.Rotate(Vector3.down, Time.deltaTime * speed * 2);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    Camera.transform.Rotate(Vector3.up, Time.deltaTime * speed * 2);
        //}
        if (Input.GetMouseButton(0))
        {
            MyAngle = 0;
            MousePos = Input.mousePosition;
            //MyAngle = Time.deltaTime  * ((MousePos.x - (Screen.width / 2)) / Screen.width);
            //Camera.transform.Rotate(Camera.transform.up, MyAngle);
            //MyAngle = Time.deltaTime * 128f * ((MousePos.y - (Screen.height / 2)) / Screen.height);
            //Camera.transform.Rotate(Camera.transform.right, -MyAngle);
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
    }
}

