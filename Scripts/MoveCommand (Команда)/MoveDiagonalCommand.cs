using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class MoveDiagonalCommand : MoveCommand
{
    private Vector3 _directionDiagonal = new Vector3(1f, -1f, 0f).normalized;


    public MoveDiagonalCommand(Transform transform, float stepDistance = 5f) : base(transform, stepDistance)
    {
    }

    public override void Execute()
    {
        _transform.position += _directionDiagonal * _stepDistance;
    }

    public override void Back()
    {
        _transform.position -= _directionDiagonal * _stepDistance;
    }

}

