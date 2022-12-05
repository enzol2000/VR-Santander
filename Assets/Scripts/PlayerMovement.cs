using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    float mSpeed = 5;
    float mSensitivity = 100;



    private void Start()
    {
        #if UNITY_STANDALONE
            Destroy(gameObject);
        #endif

        characterController = GetComponent<CharacterController>();
    }
    private void FixedUpdate()
    {
        float speed = mSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            characterController.Move(transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            characterController.Move(-transform.forward * speed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            characterController.Move(transform.right * speed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            characterController.Move(-transform.right * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            characterController.Move(transform.up * 10);
        }
        characterController.Move(-transform.up);

        float DeltaX = Input.GetAxis("Mouse X") * Time.deltaTime * mSensitivity;


        transform.Rotate(Vector3.up * DeltaX);




    }











}
