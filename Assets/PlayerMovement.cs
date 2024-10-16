using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;


    public Player PlayerInputs;

    private Vector2 Movement;



    private void Awake()
    {
        PlayerInputs = new Player();
    }

    private void OnEnable()
    {
        PlayerInputs.Enable();
    }

    private void OnDisable()
    {
        PlayerInputs.Disable();
    }

    private void Update()
    {
        #region Yo
        /* float x = Input.GetAxis("Horizontal");
         float z = Input.GetAxis("Vertical");

          Vector3 Move = new Vector3(x, 0, z);

          transform.Translate(Move*Time.deltaTime*speed);

          if (Input.GetKeyDown(KeyCode.Space))
          {
              Debug.Log("Chigga");
          }*/
        #endregion


        Movement = PlayerInputs.Action.Movement.ReadValue<Vector2>();
        transform.Translate(new Vector3(Movement.x, 0, Movement.y) * Time.deltaTime * speed);

    }
}
