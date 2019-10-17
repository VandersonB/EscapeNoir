using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JaneText : MonoBehaviour
{
    public Text[] textJane;
    private bool[] triggers;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        triggers = GameObject.Find("sceneManager").GetComponent<ObjectsManager>().BoolTrigger;
        ActiveText();
        DestroyText();
	}

    void ActiveText()
    {
        if (triggers[0] == true && triggers[1] == true &&
            triggers[2] == true)
        {//nesse caso, se o jogador tiver realizado as interações correspondentes à um tipo de solução,
         //essa solução correspondente será visível ao jogador, quando ele clicar em "Solução"    
            textJane[0].enabled=true;
        }

        if (triggers[3] == true && triggers[4] == true &&
             triggers[5] == true)
        {//nesse caso, se o jogador tiver realizado as interações correspondentes à um tipo de solução,
         //essa solução correspondente será visível ao jogador, quando ele clicar em "Solução"    
            textJane[1].enabled = true;
        }

        if (triggers[6] == true && triggers[7] == true &&
            triggers[8] == true)
        {//nesse caso, se o jogador tiver realizado as interações correspondentes à um tipo de solução,
         //essa solução correspondente será visível ao jogador, quando ele clicar em "Solução"    
            textJane[2].enabled = true;
        }

        if (triggers[9] == true && triggers[10] == true &&
            triggers[11] == true)
        {//nesse caso, se o jogador tiver realizado as interações correspondentes à um tipo de solução,
         //essa solução correspondente será visível ao jogador, quando ele clicar em "Solução"    
            textJane[3].enabled = true;
        }
    }

    void DestroyText()
    {
        if (triggers[0] == true && triggers[1] == true &&
            triggers[2] == true && textJane[0]==true)
        {//nesse caso, se o jogador tiver realizado as interações correspondentes à um tipo de solução,
         //essa solução correspondente será visível ao jogador, quando ele clicar em "Solução"    
                 }
    }
}
