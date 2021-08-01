using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterController : MonoBehaviour
{
    
    public float moveSpeed;
    public CharacterController character;
    Vector3 moveInput;
    public Transform player;
    

    public float rotationRate = 360;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moveInput.x =Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        //moveInput.z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        character.Move(moveInput);

        Vector3 horMove = transform.right * Input.GetAxis("Horizontal") * moveSpeed ;
        Vector3 verMove = transform.forward * Input.GetAxis("Vertical") * moveSpeed ;
        moveInput = horMove + verMove;
        moveInput = moveInput * moveSpeed*Time.deltaTime;

        float xAxis = Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(0, xAxis, 0) * transform.rotation;


    }
    
    
}
