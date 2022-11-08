using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] Image m_LevelComplete;
    [SerializeField] UnityEvent m_Finished;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            m_LevelComplete.gameObject.SetActive(true);
            m_Finished.Invoke();
        }
    }
}
