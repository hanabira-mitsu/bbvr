using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Left Hand
    bool L_Button_A;
    bool L_Button_A_Down;
    bool L_Button_A_Up;
    bool L_Button_B;
    bool L_Button_B_Down;
    bool L_Button_B_Up;
    bool L_Button_Stick;
    bool L_Button_Stick_Down;
    bool L_Button_Stick_Up;
    float L_Stick_Horizontal;
    float L_Stick_Vertical;
    float L_Trigger_Pull;
    bool L_Button_Trigger;
    bool L_Button_Trigger_Down;
    bool L_Button_Trigger_Up;
    bool L_Button_Grip;
    float L_Grip_Pull;
    


    // Update is called once per frame
    void LateUpdate()
    {
        
    }
    void UpdateLeft()
    {
        // Button A
        bool newButtonAState = Input.GetButton("ButtonA");
        if (newButtonAState != L_Button_A)
        {
            L_Button_A_Down = newButtonAState;
            L_Button_A_Up = !newButtonAState;
        }
        else
        {
            L_Button_A_Down = false;
            L_Button_A_Up = false;
        }
        L_Button_A = newButtonAState;

        // Repeat similar logic for other buttons...

        // Stick axes
        L_Stick_Horizontal = Input.GetAxis("Horizontal");
        L_Stick_Vertical = Input.GetAxis("Vertical");

        // Trigger
        L_Trigger_Pull = Input.GetAxis("Trigger");

        // Grip
        L_Button_Grip = Input.GetButton("Grip");
        L_Grip_Pull = Input.GetAxis("Grip");
    }
}
