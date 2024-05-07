using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfKeys { get; private set; }
    public int NumberOfCompasses { get; private set; }
    public int NumberOfToolBoxes { get; private set; }

    public UnityEvent<PlayerInventory> OnCompassCollected;
    public UnityEvent<PlayerInventory> OnKeyCollected;
    public UnityEvent<PlayerInventory> OnToolBoxCollected;

    public void KeysCollected()
    {
        NumberOfKeys++;
        OnKeyCollected.Invoke(this);
    }

    public void CompassCollected()
    {
        NumberOfCompasses++;
        OnCompassCollected.Invoke(this);
    }

    public void ToolBoxCollected()
    {
        NumberOfToolBoxes++;
        OnToolBoxCollected.Invoke(this);
    }
}
