using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 4.0F;
    private Rigidbody objRb;
    // Start is called before the first frame update
    void Start()
    {
        objRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objRb.AddForce(Vector3.forward * -speed);
    }
}
