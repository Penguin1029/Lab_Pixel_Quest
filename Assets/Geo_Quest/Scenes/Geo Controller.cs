using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{



    Rigidbody2D rb;
    int speed = 5;
    public string nextlevel = "level_2";
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {



        //if(Input.GetKeyDown(KeyCode.W))
        //transform.position += new Vector3(0, 1, 0);
        //if (Input.GetKeyDown(KeyCode.A))
        // transform.position += new Vector3(-1, 0, 0);
        //if (Input.GetKeyDown(KeyCode.S))
        // transform.position += new Vector3(0, -1, 0);
        //  if (Input.GetKeyDown(KeyCode.D))
        //  transform.position += new Vector3(1, 0, 0);

        // if (Input.GetKey(KeyCode.A))
        // rb.velocity = new Vector2 (-1, rb.velocity.y);
        // if (Input.GetKey(KeyCode.D))
        //  rb.velocity = new  Vector2 (1,rb.velocity.y);

        float xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xinput, rb.velocity.y);

        rb.velocity = new Vector2(xinput * speed, rb.velocity.y);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    { Debug.Log("Hit");
        switch (collision.tag)

        {
            case "Death":

                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                

                }
            case "Finish":
                { SceneManager.LoadScene(nextlevel);
                    break;
                
                
                }
       
        
        
        
        
        
        }
    }
}