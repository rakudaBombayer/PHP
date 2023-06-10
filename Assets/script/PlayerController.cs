using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float PlayerSpeed;
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotation();
    }

    void Move()
    {
        var speed = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            speed.z = PlayerSpeed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            speed.z = -PlayerSpeed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            speed.x = -PlayerSpeed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            speed.x = PlayerSpeed;
        }

        transform.Translate(speed);
    }

    // 1個参照
    void Rotation()
    {
        var speed = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed.y = -RotationSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed.y = RotationSpeed;
        }
        transform.eulerAngles += speed;
    }
}
