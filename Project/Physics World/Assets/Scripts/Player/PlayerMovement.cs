using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D m_Rig;
    ForceMode2D m_Force = ForceMode2D.Impulse;

    [Header("Movement")]
    [SerializeField] float m_JumpAmount = 5;
    [SerializeField] float m_MoveSpeed = 5;

    [Header("Detection")]
    [SerializeField] float m_RaycastLength = 1;
    [SerializeField]LayerMask m_Layers;

    public Button m_RightButton;
    void Start()
    {
        m_Rig = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        if (CanJump())
        {
            m_Rig.AddForce(Vector2.up * m_JumpAmount, m_Force);
        }
    }
    
    public void Right()
    {
        m_Rig.AddForce(Vector2.right * m_MoveSpeed, m_Force);
    }

    public void Left()
    {
        m_Rig.AddForce(Vector2.left * m_MoveSpeed, m_Force);
    }

    bool CanJump()
    {
        if (Physics2D.Raycast(m_Rig.position, Vector2.down, m_RaycastLength, m_Layers))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Coin>() != null)
        {
            Coin coin1 = collision.gameObject.GetComponent<Coin>();

            ScoreManager Score = FindObjectOfType<ScoreManager>();
            Score.AddCoins(coin1.GetCoinWorth());
            Score.AddScore(coin1.GetScoreWorth());

            coin1.CoinGrabbed(); //Destroy Coins
        }
    }
}
