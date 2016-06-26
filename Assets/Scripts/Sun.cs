using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour
{
    public float speed;
    private bool size;
    private bool scale;
    private float speedy;
    void Start()
    {
        speedy = 1000;
    }
    public void Update()
    {
        transform.Rotate(Vector3.down, Time.deltaTime * speed);
        if (size == true && scale == false)
        {
                speedy += 100;
                transform.localScale = new Vector3(speedy, speedy, speedy);
                if (speedy == 5000)
                {
                    size = false;
                    scale = true;
                }
        }
        if (size == true && scale == true)
        {
            speedy -= 100;
            transform.localScale = new Vector3(speedy, speedy, speedy);
            if (speedy == 1000)
            {
                size = false;
                scale = false;
            }
        }
    }
}

