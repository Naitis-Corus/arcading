using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance {get; private set;}
    NewActions newActionSystem;
    public Vector2 direction = Vector2.zero;
    void Awake()
    {
        Instance = this;
        newActionSystem = new NewActions();
        newActionSystem.Enable();
    }
    void OnDisable()
    {
        newActionSystem.Disable();
    }
    void Update()
    {
        direction = newActionSystem.MoveAction.KeybordButtons.ReadValue<Vector2>();
    
    }
    
}
