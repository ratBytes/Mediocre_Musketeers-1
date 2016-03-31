﻿using UnityEngine;
using System.Collections;
using XInputDotNetPure;

public class XCharacterController2DAbridged : MonoBehaviour
{
    /*
        public PlayerIndex playerIndex;
        public float moveSpeed = 4;
        public float jumpSpeed = 6;
        public bool enableMoveJoyJump;

        public Transform aimTransform;

        GamePadState previousState;
        GamePadState currentState;

        Vector2 moveJoy;
        Vector2 aimJoy;
        bool jump = false;
        bool moveJoyJumpLatch = false;

        void Update(){
            HandleXInput();
        }

        void HandleXInput(){
            currentState = GamePad.GetState( playerIndex );

            if(!currentState.IsConnected){
                return;
            }

            moveJoy.x = currentState.ThumbSticks.Left.X;
            moveJoy.y = currentState.ThumbSticks.Left.Y;

            aimJoy.x = currentState.ThumbSticks.Right.X;
            aimJoy.y = currentState.ThumbSticks.Right.Y;

            //jump by pushing A
            if(previousState.Buttons.A == ButtonState.Released && currentState.Buttons.A == ButtonState.Pressed){
                jump = true;
            }

            //jump by pushing up
            if(enableMoveJoyJump){
                if(!moveJoyJumpLatch){
                    if(moveJoy.y > 0.45f){
                        moveJoyJumpLatch = true;
                        jump = true;
                    }
                }
                else{
                    if(moveJoy.y < 0.45f){
                        moveJoyJumpLatch = false;
                    }
                }
            }

            //aiming
            if(aimJoy.sqrMagnitude > 0)
                aimTransform.rotation = Quaternion.LookRotation(Vector3.forward, Quaternion.Euler(0,0,90) * new Vector3( aimJoy.x, aimJoy.y, 0));

            previousState = currentState;
        }

        void FixedUpdate(){
            Vector2 velocity = rigidbody2D.velocity;

            velocity.x = moveJoy.x * moveSpeed;
            if(jump){
                velocity.y = jumpSpeed;
                jump = false;
            }

            rigidbody2D.velocity = velocity;
        }

        void OnDrawGizmos(){
            if(aimTransform != null){
                Gizmos.color = Color.red;
                Gizmos.DrawRay(aimTransform.position, aimTransform.right);
            }
        }

        void OnGUI(){
            Vector3 screenPos = Camera.main.WorldToScreenPoint(renderer.bounds.max);
            GUI.color = Color.black;
            GUI.Label(new Rect(screenPos.x, Screen.height - screenPos.y, 100, 100), playerIndex.ToString());
        }

        */
    internal PlayerIndex playerIndex;
}
