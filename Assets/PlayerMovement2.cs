using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=BJzYGsMcy8Q&list=PLx7AKmQhxJFaj0IcdjGJzIq5KwrIfB1m9&index=2
// https://www.youtube.com/watch?v=t6e2MvEG0Tc&list=PLx7AKmQhxJFaj0IcdjGJzIq5KwrIfB1m9&index=4
// https://www.youtube.com/watch?v=ynh7b-AUSPE&list=PLx7AKmQhxJFaj0IcdjGJzIq5KwrIfB1m9&index=6
// https://www.youtube.com/watch?v=2_Hn5ZsUIXM&list=PLx7AKmQhxJFaj0IcdjGJzIq5KwrIfB1m9&index=8
public class PlayerMovement2 : MonoBehaviour
{
    // Vars
    private Animator animator;
    private CharacterController characterController;
    private float? jumpButtonPressedTime;
    private float? lastGroundedTime;
    private float originalStepOffset;
    private float ySpeed;
    public float jumpButtonGracePeriod;
    public float jumpSpeed;
    public float speed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        originalStepOffset = characterController.stepOffset;
    }

    // Update is called once per frame
    void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();
        ySpeed += Physics.gravity.y * Time.deltaTime;
        if (characterController.isGrounded) {
            lastGroundedTime = Time.time;
        }
        if (Input.GetButtonDown("Jump")) {
            jumpButtonPressedTime = Time.time;
        }
        if (Time.time - lastGroundedTime <= jumpButtonGracePeriod) {
            characterController.stepOffset = originalStepOffset;
            ySpeed = -0.5f;
            if (Time.time - jumpButtonPressedTime <= jumpButtonGracePeriod) {
                ySpeed = jumpSpeed;
                jumpButtonPressedTime = null;
                lastGroundedTime = null;
            }
        }
        else {
            characterController.stepOffset = 0;
        }
        Vector3 velocity = movementDirection * magnitude;
        velocity.y = ySpeed;
        characterController.Move(velocity * Time.deltaTime);
        if (movementDirection != Vector3.zero) {
            animator.SetBool("isMoving", true);
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        else {
            animator.SetBool("isMoving", false);
        }
    }
}
