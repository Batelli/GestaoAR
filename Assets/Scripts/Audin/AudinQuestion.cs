using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Audin Question")]
public class AudinQuestion : ScriptableObject
{
    public AUDIN_Subject subject;
    public List<string> answers;
    public List<bool> answersKeys;
}
