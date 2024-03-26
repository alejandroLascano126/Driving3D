using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;


public class CarController : MonoBehaviour
{
    private Rigidbody Rigidbody;
    public float rotationSpeed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);

        
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * Time.deltaTime * 20);
            transform.Rotate(0, rotationSpeed * -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * Time.deltaTime * 20);
            transform.Rotate(0, rotationSpeed, 0);
        }
    }
}
