using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : GameManager
{
    ScoreManager m_Score;
    [SerializeField] Text m_TimerText;
    [SerializeField] Text m_TimerTextEnds;

    bool m_LevelRunning = true;

    //==================== 00:00:00
    float m_One;
    float m_Two;
    float m_Three;

    float m_Four;
    float m_Five;
    float m_Six;

    private void Awake()
    {
        m_Score = FindObjectOfType<ScoreManager>();
    }

    public void FixedUpdate()
    {
        if (m_LevelRunning)
        {
            m_Six += Time.fixedDeltaTime;

            if (m_Six > 9)
            {
                m_Five++;
                m_Six = 0;
            }
            if (m_Five > 5)
            {
                m_Four++;
                m_Five = 0;
            }
            if (m_Four > 9)
            {
                m_Three++;
                m_Four = 0;
            }
            if (m_Three > 5)
            {
                m_Two++;
                m_Three = 0;
            }
            if (m_Two > 9)
            {
                m_One++;
                m_Two = 0;
            }
            if (m_One > 9)
            {
                m_One = 0;
                m_Two = 0;
                m_Three = 0;
                m_Four = 0;
                m_Five = 0;
                m_Six = 0;
            }
            UpdateUi();
        }
    }


    void UpdateUi()
    {
        int cast1 = (int)m_One;
        int cast2 = (int)m_Two;
        int cast3 = (int)m_Three;
        int cast4 = (int)m_Four;
        int cast5 = (int)m_Five;
        int cast6 = (int)m_Six;

        m_TimerText.text = cast1.ToString() + cast2.ToString() + ":" + cast3.ToString() + cast4.ToString() + ":" + cast5.ToString() + cast6.ToString();
        m_TimerTextEnds.text = m_TimerText.text;
    }

    public void SetTimeState(bool _state)
    {
        m_LevelRunning = _state;
    }
    public int CompressValue()
    {
        return (int)m_One + (int)m_Two + (int)m_Three + (int)m_Four + (int)m_Four + (int)m_Six;
    }
}
