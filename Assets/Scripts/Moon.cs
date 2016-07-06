using UnityEngine;
using System.Collections;

public class Moon : MonoBehaviour
{
    private float speed = 409.3f;
    private GameObject moon;
    public float size = 0.3139225f;
    void Start()
    {
        moon = GameObject.Find(gameObject.name + "_Object");
        transform.localScale = new Vector3(size, size, size);
    }
    void FixedUpdate()
    {
        //transform.RotateAround(transform.parent.localPosition, Vector3.down, (Time.deltaTime * speed) / 10);
        moon.transform.Rotate(Vector3.down, Time.deltaTime * speed);
    }
}