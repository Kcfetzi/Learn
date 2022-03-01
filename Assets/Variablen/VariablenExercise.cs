using System;

public class VariablenExercise : Exercise 
{
    /**
     * In früheren Zeiten waren verschiedene Zählmaße gebräuchlich.
     *      1 Dutzend = 12 Stück
     *      1 Schock = 5 Dutzend = 60 Stück
     *      1 Gros = 12 Dutzend = 144 Stück
     *
     * Schreib ein Programm, dass die eingegebene Zahl in Gros, Schock, Dutzend und Einzelstücke ausgibt.
     * Bsp: Input = 1000
     * Ausgabe sollte sein: 6 2 1 4
     *
     * Hinweis: Rechenoperatoren verwenden (+ - * /)
     * Neu: Der Operator Modulo (%) gibt den Rest einer Division zurück. Bsp 6 % 2 = 0, 8 % 3 = 2, 7 % 3 = 1
     *      Ints können an einen string angehängt werden mit +=.
     *      Bsp: string test = "hallo";
     *          test += 10;
     *              Ausgabe test: hallo10
     *          test += " " + 5;
     *              Ausgabe test: hallo10 5
     */
    
    public override string ExerciseMethod(int input)
    {
        string output = "";
        

        return output;
    }
    
    
    
    protected override void ProzessInput()
    {
        Int32.TryParse(m_Input.text, out int inputNumber);

        if (inputNumber == 0 && m_Input.text != "0")
        {
            Instantiate(m_ErrorTextEntry, m_Content).text = "Ungültige Eingabe";
            Instantiate(m_ErrorTextEntry, m_Content).text = "\n";
            return;
        }

        string output = ExerciseMethod(inputNumber);
        Instantiate(m_OutputTextEntry, m_Content).text = output;
        Instantiate(m_InputTextEntry, m_Content).text = "> " + m_Input.text;
        Instantiate(m_OutputTextEntry, m_Content).text = "\n";
    }
}
