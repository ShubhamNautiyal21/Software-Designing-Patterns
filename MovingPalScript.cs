using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPalScript : MonoBehaviour
{
    IMovementController iMov;
    MoveLeft left = new MoveLeft();
    MoveRight right=new MoveRight();
    MoveUp up=new MoveUp();
    MoveDown down=new MoveDown();
    Movement mov=new Movement();
    bool moving;

    /// <summary>
    /// Use the commented code only when you want to implement command based pattern as it requires new operator every time
    /// you can cache the movement in order to iterate in the commands
    /// </summary>

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //mov = new Movement(up);
            //mov.Execute();
            iMov = up;
            moving = true;
          
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //mov = new Movement(down);
            //mov.Execute();
            iMov = down;
            moving = true;


        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            //mov = new Movement(left);
            //mov.Execute();
            iMov = left;
            moving = true;


        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //mov = new Movement(right);
            //mov.Execute();
            iMov = right;
            moving = true;


        }
        if (moving) { 
            moving = false;
            mov.Execute(iMov);
        }

    }

}
