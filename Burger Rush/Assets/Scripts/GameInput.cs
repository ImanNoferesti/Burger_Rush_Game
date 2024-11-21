using Unity.VisualScripting.InputSystem;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    PlayerInputActions playerInputAction;
    void Awake()
    {
        playerInputAction = new PlayerInputActions();
        playerInputAction.Player.Enable();
    }
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputAction.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
        
    }
}
