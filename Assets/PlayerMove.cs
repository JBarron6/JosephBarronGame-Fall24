using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed;
    int dirx;
    int diry;
    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirx = 0;
        diry = 0;
        if (Input.GetKey(KeyCode.D))
        {
            dirx++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            dirx--;
        }
        if (Input.GetKey(KeyCode.W))
        {
            diry++;
        }
        if (Input.GetKey(KeyCode.S))
        {
            diry--;
        }
        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x + dirx * speed * Time.deltaTime, pos.y + diry * speed * Time.deltaTime, pos.z);
    }   
}
