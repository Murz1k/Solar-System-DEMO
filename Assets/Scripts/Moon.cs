using UnityEngine;
using System.Collections;

public class Moon : MonoBehaviour
{
    private float speed = 409.3f;
    public Earth earth;
    private GameObject moon;
    public float size = 0.3139225f;
    private Vector3 earthPosition;
    void Start()
    {
        //earth = GetComponent<Earth>();
        moon = GameObject.Find(gameObject.name + "_Object");
        transform.localScale = new Vector3(size, size, size);
    }
    void Update()
    {
        //transform.RotateAround(transform.parent.localPosition, Vector3.down, (Time.deltaTime * speed) / 10);
        moon.transform.Rotate(Vector3.down, Time.deltaTime * speed);
    }
}