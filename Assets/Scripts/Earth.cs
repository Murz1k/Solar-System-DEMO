using UnityEngine;
using System.Collections;

public class Earth : MonoBehaviour
{
    public float speed = 31.4f;
    public float size = 6.371f;
    public GameObject earth;
    void Start()
    {
        transform.localScale = new Vector3(size, size, size);
    }
   public void Update()
    {
        transform.RotateAround(Vector3.up, Vector3.down, Time.deltaTime * speed);//Вращение вокруг солнца
        earth.transform.Rotate(Vector3.down, Time.deltaTime * speed);// Вращение вокруг своей оси
    }
    
}
