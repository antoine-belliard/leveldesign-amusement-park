using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //déplacement 
    float inputX;
    float inputZ;
    CharacterController cc;
    Vector3 mouvement;
    public float vitesse = 0.3f;


    //camera
    public float vitesseRotation = 50.0f;
    float mouseX;
    float mouseY;
    float minAngle = -90f;
    float maxAngle = 90f;
    float rotY;
    float rotX;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        MoveCamera();
    }

    private void FixedUpdate()
    {
        mouvement = transform.forward * inputZ * vitesse + transform.right * inputX * vitesse;
        mouvement.y = 0;
        GetComponent<CharacterController>().Move(mouvement);
    }

    private void MoveCamera()
    {
        rotY = mouseX * vitesseRotation;
        rotX += mouseY * vitesseRotation;

        rotX = Mathf.Clamp(rotX, minAngle, maxAngle);

        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + rotY, 0);
    }
}
