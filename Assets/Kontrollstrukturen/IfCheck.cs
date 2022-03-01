using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfCheck : Check
{
    [SerializeField] private IfExercise m_Exercise;
    
    public override void CheckSolution()
    {
        int result = m_Exercise.ExerciseMethod(1, 2);
        if (result != 1000)
        {
            Debug.Log("Test failed!");
            return;
        }

        result = m_Exercise.ExerciseMethod(5, 5);
        if (result != 500)
        {
            Debug.Log("Test failed!");
            return;
        }
        
        result = m_Exercise.ExerciseMethod(3, 3);
        if (result != 300)
        {
            Debug.Log("Test failed!");
            return;
        }
        
        result = m_Exercise.ExerciseMethod(8, 9);
        if (result != 98)
        {
            Debug.Log("Test failed!");
            return;
        }
        
        result = m_Exercise.ExerciseMethod(1, 7);
        if (result != 71)
        {
            Debug.Log("Test failed!");
            return;
        }
        
        Debug.Log("Test bestanden!");
    }
}
