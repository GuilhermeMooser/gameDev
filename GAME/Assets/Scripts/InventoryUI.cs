using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{

    private TextMeshProUGUI keyText;
    private TextMeshProUGUI compassText;
    private TextMeshProUGUI toolBoxText;

    void Start()
    {
        keyText = GetComponent<TextMeshProUGUI>();
        compassText = GetComponent<TextMeshProUGUI>();
        toolBoxText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateKeyText(PlayerInventory playerInventory)
    {
        keyText.text = playerInventory.NumberOfKeys.ToString();
    }

    public void UpdateCompassText(PlayerInventory playerInventory)
    {
        compassText.text = playerInventory.NumberOfCompasses.ToString();
    }

    public void UpdateToolBoxText(PlayerInventory playerInventory)
    {
        toolBoxText.text = playerInventory.NumberOfToolBoxes.ToString();
    }

}
