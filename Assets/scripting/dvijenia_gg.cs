using UnityEngine;
using UnityEngine.InputSystem;

public class dvijenia_gg : MonoBehaviour
{
    public static dvijenia_gg odin_na_vesi_mir {get; private set;}
    NewActions gg_knopkishi;
    public Vector2 naprav = Vector2.zero;
    void Awake()
    {
        odin_na_vesi_mir = this;
        gg_knopkishi = new NewActions();
        gg_knopkishi.Enable();
    }
    void OnDisable()
    {
        gg_knopkishi.Disable();
    }
    void Update()
    {
        naprav = gg_knopkishi.dvijenia.knopkishi.ReadValue<Vector2>();
    
    }
    
}
