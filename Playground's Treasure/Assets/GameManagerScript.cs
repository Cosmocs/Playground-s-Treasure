using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public float speed;
    public float hspeed = 0;
    public float vspeed = 0;
    private CharacterController controller;
    private Vector3 playerVelocity;

    // Start is called before the first frame update
   private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }


    // Update is called once per frame
   void Update()
{
    Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    controller.Move(move * Time.deltaTime * speed);

    if (move != Vector3.zero)
    {
        gameObject.transform.forward = move;
    }
}

}

