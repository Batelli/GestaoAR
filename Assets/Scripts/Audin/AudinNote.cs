using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AudinNote : MonoBehaviour
{
    public TMP_Text audinCode;
    public TMP_Text[] audinQ;

    public void LoadNote(string keyCode)
    {
        audinCode.text = "Caso: " + keyCode.ToUpper();

        string[] str = AudinQuestionTranslator.Instance.GetAllAnswerText(keyCode);
        for (int i = 0; i < str.Length; i++)
        {
            if (i >= audinQ.Length)
                return;

            audinQ[i].text = str[i];
        }
    }
}
