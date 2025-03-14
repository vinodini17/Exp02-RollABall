using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float xforce=5.0f;
    public float zforce = 5.0f;
    public float yforce=100.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x =0.0f, y=0.0f , z=0.0f;
        if(Input.GetKey(KeyCode.A))
        {
            x=x-xforce;
        }
        if(Input.GetKey(KeyCode.D))
        {
            x=x+xforce;
        }
        if(Input.GetKey(KeyCode.W))
        {
            z=z+zforce;
        }
        if(Input.GetKey(KeyCode.X))
        {
            z=z-zforce;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            y=yforce;
        }
        GetComponent<Rigidbody>().AddForce(x,y,z);
        

    }
}
