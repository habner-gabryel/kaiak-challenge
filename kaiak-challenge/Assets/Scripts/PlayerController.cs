using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    public float horizontalInput;
    private float speed = 15F;
    private float xRange = 15F;

    public int pontos = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0){
            if(transform.position.x >= xRange && horizontalInput > 0){
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            } else if(transform.position.x <= -xRange && horizontalInput < 0){
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            } else {
                transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
            }
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Pedra")){
            Destroy(gameObject);
        } else if(collision.gameObject.CompareTag("Rampa")){
            playerRb.AddForce(Vector3.up * speed * collision.transform.position.y, ForceMode.Impulse);
            pontos += 5;
        } else if(collision.gameObject.CompareTag("Bandeira")){
            pontos += 2;
        }
    }
}
