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

    public GameObject youWinCanvas;
    bool isWin = false;

    public int NumberOfToolBoxesToWin = 3;

    void Start()
    {
        youWinCanvas.SetActive(false);
    }

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

    void Update() {
        if (NumberOfToolBoxes == NumberOfToolBoxesToWin && !isWin) {
            isWin = true;
            YouWin();
        }
    }

    void YouWin() {
        youWinCanvas.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("merda");
    }
}
