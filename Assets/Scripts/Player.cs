using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement Speed")]
    public float speed = 8; // Speed of player

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))//use the "W" key 
        {
            this.transform.position += Vector3.forward * speed * Time.deltaTime; // Move forwards
        }
        if (Input.GetKey(KeyCode.A))//use the "A" key 
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime; // Move left
        }
        if (Input.GetKey(KeyCode.S))//use the "S" key 
        {
            this.transform.position += Vector3.back * speed * Time.deltaTime; // Move backwards
        }
        if (Input.GetKey(KeyCode.D))//use the "D" key 
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime; // Move right
        }
    }
}
