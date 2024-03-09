using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StamineBar : MonoBehaviour
{
    public Slider sliderStamine;

    public void ColocarEstaminaMaxima(float stamine)
    {
        sliderStamine.maxValue = stamine;
        sliderStamine.value = stamine;
    }

    public void AlterarEstamina(float stamine)
    {
        sliderStamine.value = stamine;
    }

}
