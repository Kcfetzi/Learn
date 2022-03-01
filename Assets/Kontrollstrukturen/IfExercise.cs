using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfExercise : Exercise
{
    
    /**
     * Beim Spiel Mäxchen wird mit zwei Würfeln gewürfelt. Die Augen beider Würfel geben die Punktzahl an.
     * Der Wurf 1 und 2 heißt Mäxchen und gibt 1000 Punkte.
     * Ein Wurf mit zwei gleichen Augenzahlen heißt Pasch und ist 100 * der Augenzahl wert. 4 und 4 sind also 400 Punkte.
     * Alle anderen Würfe sind 10 * höhere Augenzahl + niedrigere Augenzahl wert. 3 und 5 sind also 53.
     *
     * Ergänze die Methode ExercieMethod so, dass die korrekte Punkteanzahl zurückgegeben wird.
     * Im Input müssen die Zahlen mit Komma getrennt eingegeben werden. Bsp: "5,3" entspricht: first = 5, second = 3
     */
    
    public override int ExerciseMethod(int first, int second)
    {
        return 0;
    }
    
    
    
    protected override void ProzessInput()
    {
        string[] input = m_Input.text.Split(',');

        if (input.Length != 2)
        {
            Instantiate(m_ErrorTextEntry, m_Content).text = "Ungültige Eingabe";
            Instantiate(m_ErrorTextEntry, m_Content).text = "\n";
            return;
        }
        
        Int32.TryParse(input[0], out int firstNumber);
        Int32.TryParse(input[1], out int secondNumber);

        if (firstNumber == 0 && input[0] != "0" || secondNumber == 0 && input[1] != "0")
        {
            Instantiate(m_ErrorTextEntry, m_Content).text = "Ungültige Eingabe";
            Instantiate(m_ErrorTextEntry, m_Content).text = "\n";
            return;
        }

        int output = ExerciseMethod(firstNumber, secondNumber);
        Instantiate(m_OutputTextEntry, m_Content).text = output.ToString();
        Instantiate(m_InputTextEntry, m_Content).text = "> " + m_Input.text;
        Instantiate(m_OutputTextEntry, m_Content).text = "\n";
    }
}
