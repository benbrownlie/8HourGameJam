using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    public float MoveForce = 5.0f;
    public float JumpForce = 5.0f;
    Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //    transform.position += Vector3.forward * MoveForce * Time.deltaTime;

        //if (Input.GetKey(KeyCode.S))
        //    transform.position += Vector3.back * MoveForce * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * MoveForce * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * MoveForce * Time.deltaTime;

        //if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 0.5)
        //    _rigidbody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
    }
}
