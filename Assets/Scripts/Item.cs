using UnityEngine;

public abstract class Item
{
    protected string nome;
    protected bool acumulavel;

    public void Examinar()
    {
        Debug.Log("Isto é um(a): " + nome);
    }
}

   

