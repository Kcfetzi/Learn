using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public abstract class Exercise : MonoBehaviour
{
    [SerializeField] protected TMP_InputField m_Input;
    [SerializeField] protected RectTransform m_Content;
    [SerializeField] protected TMP_Text m_InputTextEntry;
    [SerializeField] protected TMP_Text m_OutputTextEntry;
    [SerializeField] protected TMP_Text m_ErrorTextEntry;

    private void Awake()
    {
        m_Input.Select();
        m_Input.ActivateInputField();
    }

    protected abstract void ProzessInput();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ProzessInput();
            LayoutRebuilder.ForceRebuildLayoutImmediate(m_Content);
            m_Input.text = "";
            m_Input.Select();
            m_Input.ActivateInputField();
        }
    }

    public virtual string ExerciseMethod(int input)
    {
        return "";
    }
    
    public virtual int ExerciseMethod(int first, int second)
    {
        return 0;
    }
}
