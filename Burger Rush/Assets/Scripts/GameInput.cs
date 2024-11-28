using System;
using Unity.VisualScripting.InputSystem;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    PlayerInputActions playerInputActions;
    public event EventHandler OnInteractAction;
    void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

        playerInputActions.Player.Interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        // if (OnInteractAction != null)
        // {
        //     OnInteractAction(this, EventArgs.Empty);
        // }

        // Same as above lines (compact)
        OnInteractAction?.Invoke(this, EventArgs.Empty); 
        
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
        
    }
}
