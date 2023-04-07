using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveLeft : IMovementController
{
    public void Execute() => Debug.LogError("Move left");

}
public class MoveUp : IMovementController
{
    public void Execute() => Debug.LogError("Move Up");

}
public class MoveRight : IMovementController
{
    public void Execute() => Debug.LogError("Move Right");

}
public class MoveDown : IMovementController
{
    public void Execute() => Debug.LogError("Move Down");

}
/// <summary>
/// Use the commented code only when you want to implement command based pattern as it requires new operator every time
/// </summary>
public class Movement
{


    //private IMovementController _move;
    //public Movement(IMovementController imovementController)
    //{
    //    _move = imovementController;
    //}

    public void Execute(IMovementController imovementController)
    {
        imovementController.Execute();
    }
}
