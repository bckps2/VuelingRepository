using System;

/// <summary>
/// Summary description for Extensores
/// </summary>
public class Extensores

{
    
    public static Boolean HasName(this Persona person)
    {
        if (string.IsNullOrEmpty(person.Name) || string.IsNullOrWhiteSpace(person.Name))
        {
            return false;
        }
        else { return true; }

    }
}
