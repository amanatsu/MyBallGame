using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(5f,15f);
        //Debug.Log(speed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f,0f, speed * -1 * Time.deltaTime);
        if (transform.position.z < -13.0f)
        {
            //Debug.Log("game over!");
            //Time.timeScale = 0;
            SceneManager.LoadScene("GameOverScene");
        }
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            //Debug.Log($"{collision.gameObject.transform.localScale.x}-{collision.gameObject.transform.localScale.y}-{collision.gameObject.transform.localScale.z}");
            Destroy(gameObject);
            float randomX = Random.Range(0.2f, 1f);
            collision.gameObject.transform.localScale -= new Vector3(randomX, 0f, 0f);
            if (collision.gameObject.transform.localScale.x < 1.0f)
            {
                collision.gameObject.transform.localScale = 
                    new Vector3(1f, 
                    collision.gameObject.transform.localScale.y,
                    collision.gameObject.transform.localScale.z);
            }
        }
    }
}
