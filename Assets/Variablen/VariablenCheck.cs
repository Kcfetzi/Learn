using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablenCheck : Check
{
    [SerializeField] private VariablenExercise m_Exercise;

    public override void CheckSolution()
    {
        string result = m_Exercise.ExerciseMethod(1000);
        if (result != "6 2 1 4")
        {
            Debug.Log("Test failed!");
            return;
        }

        result = m_Exercise.ExerciseMethod(0);
        if (result != "0 0 0 0")
        {
            Debug.Log("Test failed!");
            return;
        }

        result = m_Exercise.ExerciseMethod(144);
        if (result != "1 0 0 0")
        {
            Debug.Log("Test failed!");
            return;
        }

        result = m_Exercise.ExerciseMethod(100);
        if (result != "0 1 3 4")
        {
            Debug.Log("Test failed!");
            return;
        }
        
        result = m_Exercise.ExerciseMethod(200);
        if (result != "1 0 4 8")
        {
            Debug.Log("Test failed!");
            return;
        }
        
        result = m_Exercise.ExerciseMethod(300);
        if (result != "2 0 1 0")
        {
            Debug.Log("Test failed!");
            return;
        }
        
        Debug.Log("Test bestanden!");
    }
}
