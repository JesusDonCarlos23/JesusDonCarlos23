using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private float speed = 20.0f;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        //Move vehicle forward
        forwardInput = Input.GetAxis("Vertical");
        //moves car based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

    }
}
