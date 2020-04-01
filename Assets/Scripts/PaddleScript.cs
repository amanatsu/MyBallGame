using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x * Time.deltaTime * speed, 0f, 0f);
        //Debug.Log(transform.position.x);

        //float z = Input.GetAxis("Vertical");
        //transform.position += new Vector3(0f, 0f, z * Time.deltaTime * speed);
    }
}
