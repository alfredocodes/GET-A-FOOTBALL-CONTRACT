using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    public float horizontalSpeed = 1f;

    public float verticalSpeed = 1f;

    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal")*horizontalSpeed * Time.deltaTime,
            0f,
            Input.GetAxis("Vertical")* verticalSpeed* Time.deltaTime);

        controller.Move(direction);
    }
}
