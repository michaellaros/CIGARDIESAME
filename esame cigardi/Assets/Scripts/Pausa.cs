using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    private bool m_Pausa;
    // Start is called before the first frame update
    void Start()
    {
        m_Pausa = false;
    }

    public void OnPausa() 
    {
        m_Pausa = true;
    }

    public void OffPausa() 
    {
        m_Pausa = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Pausa)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }
}
