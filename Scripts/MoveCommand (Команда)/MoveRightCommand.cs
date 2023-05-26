using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class MoveRightCommand : MoveCommand
{
    public MoveRightCommand(Transform transform, float stepDistance = 10f) : base(transform, stepDistance)
    {
    }

    public override void Execute()
    {
        _transform.position += Vector3.right * _stepDistance;
    }

    public override void Back()
    {
        _transform.position -= Vector3.right * _stepDistance;
    }
}

