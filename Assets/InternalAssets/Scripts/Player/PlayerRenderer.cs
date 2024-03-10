
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerRenderer : MonoBehaviour
{
    [SerializeField] private float m_Speed = 20;
    private Vector2 m_Move = new Vector2();

    private Rigidbody2D m_Body;


    private void OnValidate()
    {
        m_Body = GetComponent<Rigidbody2D>();
    }


    public void FixedUpdate()
    {
        m_Body.velocity = m_Move * m_Speed;
    }

    private void OnMove(InputValue input)
    {
        m_Move = input.Get<Vector2>();
    }
}
