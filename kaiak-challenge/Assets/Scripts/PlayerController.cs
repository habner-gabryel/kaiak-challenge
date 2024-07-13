using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 15F;

    private float xRange = 15F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0){
            if(transform.position.x > xRange){
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            } else if(transform.position.x < -xRange){
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            } else {
                transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
            }
        }
    }
}
