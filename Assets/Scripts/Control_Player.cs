using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Player : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
