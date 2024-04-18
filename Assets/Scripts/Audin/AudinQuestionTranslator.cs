using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudinQuestionTranslator : MonoBehaviour
{
    public static AudinQuestionTranslator Instance { get; private set; }

    private void Awake()
    {
        //Singleton
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    public string GenerateCode()
    {
        return "";
    }

    public bool IsTheCodeValid(string keyCode)
    {
        int index = GetQuestionIndex(keyCode);
        if (index < 0)  //|| index >= itemCatalogue.Length <<<<<<<<<<<<<<<<<<<<<<< Modificar
            return false;

        return true;
    }

    public int GetQuestionIndex(string keyCode)
    {
        return GetDecodedIndex(keyCode.Substring(3, 1)) + (GetDecodedIndex(keyCode.Substring(2, 1)) * 10) + (GetDecodedIndex(keyCode.Substring(1, 1)) * 100);
    }

    string GetQuestionCode()
    {
        return GetEncodedChar("".Substring(0, 1)) + GetEncodedChar("".Substring(1, 1) + GetEncodedChar("".Substring(2, 1)));
    }

    string GetEncodedChar(string str)
    {
        string[] strList;

        switch (str)
        {
            case "0":
                strList = new string[4] { "A", "K", "U", "5" };
                return strList[Random.Range(0, strList.Length)];
            case "1":
                strList = new string[4] { "B", "L", "V", "6" };
                return strList[Random.Range(0, strList.Length)];
            case "2":
                strList = new string[4] { "C", "M", "W", "7" };
                return strList[Random.Range(0, strList.Length)];
            case "3":
                strList = new string[4] { "D", "N", "X", "8" };
                return strList[Random.Range(0, strList.Length)];
            case "4":
                strList = new string[4] { "E", "O", "Y", "9" };
                return strList[Random.Range(0, strList.Length)];
            case "5":
                strList = new string[3] { "F", "P", "Z" };
                return strList[Random.Range(0, strList.Length)];
            case "6":
                strList = new string[3] { "G", "Q", "1" };
                return strList[Random.Range(0, strList.Length)];
            case "7":
                strList = new string[3] { "H", "R", "2" };
                return strList[Random.Range(0, strList.Length)];
            case "8":
                strList = new string[3] { "I", "S", "3" };
                return strList[Random.Range(0, strList.Length)];
            case "9":
                strList = new string[3] { "J", "T", "4" };
                return strList[Random.Range(0, strList.Length)];
        }

        return str;
    }

    int GetDecodedIndex(string str)
    {
        switch (str)
        {
            case "A":
            case "K":
            case "U":
            case "5":
                return 0;
            case "B":
            case "L":
            case "V":
            case "6":
                return 1;
            case "C":
            case "M":
            case "W":
            case "7":
                return 2;
            case "D":
            case "N":
            case "X":
            case "8":
                return 3;
            case "E":
            case "O":
            case "Y":
            case "9":
                return 4;
            case "F":
            case "P":
            case "Z":
                return 5;
            case "G":
            case "Q":
            case "1":
                return 6;
            case "H":
            case "R":
            case "2":
                return 7;
            case "I":
            case "S":
            case "3":
                return 8;
            case "J":
            case "T":
            case "4":
                return 9;
        }

        return 0;
    }
}
