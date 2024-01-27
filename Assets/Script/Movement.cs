using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController charController;
    public float movementSpeed;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public AudioSource bgSound;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Bergerak();
    }



    void Bergerak()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, 0, moveZ);




        charController.Move(move * movementSpeed * Time.deltaTime);
        float moveAnime = new Vector2(moveX, moveZ).magnitude;

        if (moveX == 0 || moveZ == 0) return;

        float heading = Mathf.Atan2(moveX, moveZ) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, heading, ref turnSmoothVelocity, turnSmoothTime);
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }
}
