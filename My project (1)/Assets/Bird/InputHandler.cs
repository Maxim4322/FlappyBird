using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class InputHandler : MonoBehaviour
 {
    [SerializeField] private BirdMover _birdMover;

    private InputSchem _inputs;

    private void Awake()
    {
        if (_birdMover == null) {
            enabled = false;
            return;
        }
        _inputs = new InputSchem();

    }

    private void OnEnable()
    {
        _inputs.Enable();
        _inputs.ActionMap.Jump.performed += OnTouch;
    }


    private void OnTouch(CallbackContext context)
    {
        _birdMover.Jump();
    }
 }    