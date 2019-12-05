using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FixMyProject.GamePlay
{
    public class PlayerMovement : MonoBehaviour
    {
        bool canMove;
        private void Update()
        {
            //Move player

            //Check if player is allowed to move
            if (Input.GetMouseButton(0) &&
             GameObject.Find("[GameManager]").GetComponent<GameManager>().gameState == GameState.Playing &&
             canMove)
            {
                //Translate player to main cameras forward direction
                transform.Translate(Camera.main.transform.forward * GameObject.Find("[GameManager]").GetComponent<GameManager>().playerMoveSpeed * Time.deltaTime);
            }
        }

        private float rayCastResolution = 100;
        private float rayDistance = 1;
        private void FixedUpdate()
        {
            //Send rays in front of the player in order to determine if there is any objects in front of the player, if there is: don't allow the player to keep walking.
            //The amount of rays sent is equal to the rayCastResolution
            for (int i = 0; i < rayCastResolution; i++)
            {
                RaycastHit hit;
                //Raycast from camera and downwards along the body of the player;
                Physics.Raycast(Camera.main.transform.position + Vector3.down * i * 0.01f, Camera.main.transform.forward * rayDistance, out hit, Mathf.Infinity);


                if (hit.distance < rayDistance)
                    canMove = false;
                else canMove = true;

                Debug.DrawRay(Camera.main.transform.position + Vector3.down * i * 0.01f, Camera.main.transform.forward * rayDistance, Color.yellow);
            }
        }
    }
}