using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gameMenage : MonoBehaviour
{
    public int moedas;
    public TMP_Text hud, msgVitoria;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        moedas = FindObjectsOfType<coin>().Length;
        AtualizandoHud();

    }

    public void AtualizandoHud()
    {
        hud.text = $"Moedas restante: {moedas}";
        
    }

    public void SubtrairMoedas(int valor)
    {
        moedas -= valor;
        AtualizandoHud();
        if (moedas <= 0)
        {
            msgVitoria.text = "parabens";
        }

    }
}