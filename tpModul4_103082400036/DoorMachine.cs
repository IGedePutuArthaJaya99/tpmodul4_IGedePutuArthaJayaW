using System;

namespace tpModul4_103082400036;

public class DoorMachine
{
    public enum DoorState { Terkunci, Terbuka }
    private DoorState currentState;

    public DoorMachine()
    {
       
        currentState = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        currentState = DoorState.Terbuka;
        Console.WriteLine("Pintu tidak terkunci"); 
    }

    public void KunciPintu()
    {
        currentState = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci"); 
    }
}