using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    [SerializeField] private Button _buttonStepRight;
    [SerializeField] private Button _buttonStepDiagonal;
    [SerializeField] private Button _buttonStepDown;
    [SerializeField] private Button _buttonStepBack;
    [SerializeField] private Transform _pivotTransform;

    private List<MoveCommand> _moveJournal = new List<MoveCommand>();
    private void OnEnable()
    {
        _buttonStepRight.onClick.AddListener(StepRight);
        _buttonStepDiagonal.onClick.AddListener(StepDiagonal);
        _buttonStepDown.onClick.AddListener(StepDown);
        _buttonStepBack.onClick.AddListener(BackLastStep);
    }

    private void OnDisable()
    {
        _buttonStepRight.onClick.RemoveListener(StepRight);
        _buttonStepDiagonal.onClick.RemoveListener(StepDiagonal);
        _buttonStepDown.onClick.RemoveListener(StepDown);
        _buttonStepBack.onClick.RemoveListener(BackLastStep);
    }

    private void StepRight()
    {
        var move = new MoveRightCommand(_pivotTransform);
        move.Execute();
        _moveJournal.Add(move);
    }

    private void StepDown()
    {
        var move = new MoveDownCommand(_pivotTransform);
        move.Execute();
        _moveJournal.Add(move);
    }

    private void StepDiagonal()
    {
        var move = new MoveDiagonalCommand(_pivotTransform);
        move.Execute();
        _moveJournal.Add(move);
    }

    private void BackLastStep()
    {
        if (_moveJournal.Count > 0)
        {
            var lastMove = _moveJournal[_moveJournal.Count - 1];
            lastMove.Back();
            _moveJournal.Remove(lastMove);
        }

    }

}
