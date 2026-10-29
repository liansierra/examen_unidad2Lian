using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 4f;

    private Rigidbody2D rb;
    private Vector2 movimiento;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        movimiento = value.Get<Vector2>();
    }

    void Update()
    {
        if (movimiento.y > 0)
        {
            rb.linearVelocity = Vector2.up * velocidad;
            transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }
        else if (movimiento.y < 0)
        {
            rb.linearVelocity = Vector2.down * velocidad;
            transform.eulerAngles = new Vector3(0f, 0f, -90f);
        }
        else if (movimiento.x < 0)
        {
            rb.linearVelocity = Vector2.left * velocidad;
            transform.eulerAngles = new Vector3(0f, 0f, 180f);
        }
        else if (movimiento.x > 0)
        {
            rb.linearVelocity = Vector2.right * velocidad;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}
