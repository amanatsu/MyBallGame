using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        //0秒からスタート　一秒ごとに実行
        InvokeRepeating("SpawnBall",0f,1f);
    }

    private void SpawnBall()
    {
        Vector3 position = new Vector3(Random.Range(-5f,5f),transform.position.y, transform.position.z);
        Instantiate(ball, position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
