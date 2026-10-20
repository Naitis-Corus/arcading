using UnityEngine;

public class geroi : MonoBehaviour
{
    [SerializeField] float move_speed = 30f;
    [SerializeField] float jump_speed = 10f;
    [SerializeField] float shag_uscirenia = 5f;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (rb.linearVelocityY <= 0 && collision.GetContact(0).normal.y > 0.5f)
        {
            rb.linearVelocityY = jump_speed;
        }
    }


    void Update()
    {
        
        rb.linearVelocityX = Mathf.MoveTowards(rb.linearVelocityX,dvijenia_gg.odin_na_vesi_mir.naprav.x * move_speed,shag_uscirenia);
    }
}
