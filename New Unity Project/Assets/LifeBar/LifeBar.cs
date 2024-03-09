using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Slider sliderLife;

    public void ColocarVidaMaxima(float vida)
    {
        sliderLife.maxValue = vida;
        sliderLife.value = vida;
    }

    public void AlterarVida(float vida)
    {
        sliderLife.value = vida;
    }

}
