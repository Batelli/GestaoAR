using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Audin Question")]
public class AudinQuestion : ScriptableObject
{
    public string question;
    public string[] answers;
    public bool[] answersKeys;
}
