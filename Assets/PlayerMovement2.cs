using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=BJzYGsMcy8Q&list=PLx7AKmQhxJFaj0IcdjGJzIq5KwrIfB1m9&index=2
// https://www.youtube.com/watch?v=t6e2MvEG0Tc&list=PLx7AKmQhxJFaj0IcdjGJzIq5KwrIfB1m9&index=4
public class PlayerMovement2 : MonoBehaviour
{
    
    private CharacterController characterController;
    public float speed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();
        characterController.SimpleMove(movementDirection * magnitude);
        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
