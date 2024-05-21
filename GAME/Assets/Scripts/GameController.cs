using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogo : MonoBehaviour
{
    public LifeBar lifeBar;
    public StamineBar stamineBar;
    private float vida = 100.0f;
    private float stamine = 100.0f;

    void Start()
    {
        vida = 100.0f;
        stamine = 100.0f;
        lifeBar.ColocarVidaMaxima(vida); //Colocando uma vida maxima 
        stamineBar.ColocarEstaminaMaxima(stamine); //Colocando uma estamina maxima 
    }

    void Update()
    {
        /*LIFE BAR*/
        if(Input.GetKeyDown(KeyCode.Space))
        {
            vida -= 10.0f; //Damage
            lifeBar.AlterarVida(vida);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            vida += 10.0f; //Heal
            lifeBar.AlterarVida(vida);
        }

        /*STAMINE BAR*/
        if (Input.GetKeyDown(KeyCode.S))
        {
            stamine -= 10.0f; //Lose Stamine
            stamineBar.AlterarEstamina(stamine);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            stamine += 10.0f; //Earn Stamine
            stamineBar.AlterarEstamina(stamine);
        }
    }
}
