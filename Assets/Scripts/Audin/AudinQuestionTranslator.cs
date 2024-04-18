using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AUDIN_Subject { Recebimento, None }


public class AudinQuestionTranslator : MonoBehaviour
{
    public static AudinQuestionTranslator Instance { get; private set; }
    public AudinQuestion recebimentoQuestions;


    private void Awake()
    {
        //Singleton
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    #region Encode
    // AXXYYZZ - A Subject, XX Question 1, YY Question 2, ZZ Question 3
    public string GenerateCode(AUDIN_Subject subject)
    {
        string newKey = GetEncodedSubject(subject);
        int max, num1, num2, num3;

        max = GetQuestionLength(subject);
        num1 = Random.Range(0, max);

        do
        {
            num2 = Random.Range(0, max);
        }
        while (num2 == num1);

        do
        {
            num3 = Random.Range(0, max);
        }
        while (num3 == num1 || num3 == num2);


        string str = num1.ToString("00") + num2.ToString("00") + num3.ToString("00");
        newKey += GetEncodedChar(str.Substring(0, 1)) + GetEncodedChar(str.Substring(1, 1)) +
                    GetEncodedChar(str.Substring(2, 1)) + GetEncodedChar(str.Substring(3, 1)) +
                    GetEncodedChar(str.Substring(4, 1)) + GetEncodedChar(str.Substring(5, 1));

        return newKey;
    }

    string GetEncodedSubject(AUDIN_Subject subject)
    {
        string[] strList;

        switch (subject)
        {
            case AUDIN_Subject.Recebimento:
                strList = new string[8] { "A", "E", "I", "M", "Q", "U", "Y", "3" };
                return strList[Random.Range(0, strList.Length)];
        }

        return "";
    }

    int GetQuestionLength(AUDIN_Subject subject)
    {
        switch (subject)
        {
            case AUDIN_Subject.Recebimento:
                return recebimentoQuestions.answers.Count;

            default:
                return 0;
        }
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

    #endregion Encode

    #region Decode

    public AUDIN_Subject GetSubject(string keyCode)
    {
        switch (keyCode)
        {
            case "A":
            case "E":
            case "I":
            case "M":
            case "Q":
            case "U":
            case "Y":
            case "3":
                return AUDIN_Subject.Recebimento;

            default:
                return AUDIN_Subject.None;
        }
    }

    public bool IsTheCodeValid(string keyCode)
    {
        AUDIN_Subject subject = GetSubject(keyCode);
        if (subject == AUDIN_Subject.None)
            return false;


        int[] indexList = GetQuestionIndex(keyCode);
        for (int i = 0; i < indexList.Length; i++)
        {
            if (indexList[i] < 0 || indexList[i] >= GetQuestionLength(subject))
                return false;
        }

        return true;
    }

    public int[] GetQuestionIndex(string keyCode)
    {
        int[] indexList = new int[3];
        indexList[0] = GetDecodedIndex(keyCode.Substring(2, 1)) + (GetDecodedIndex(keyCode.Substring(1, 1)) * 10);
        indexList[1] = GetDecodedIndex(keyCode.Substring(4, 1)) + (GetDecodedIndex(keyCode.Substring(3, 1)) * 10);
        indexList[2] = GetDecodedIndex(keyCode.Substring(6, 1)) + (GetDecodedIndex(keyCode.Substring(5, 1)) * 10);

        return indexList;
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

    public string GetAnswerText(int index, AUDIN_Subject subject)
    {
        if (subject == AUDIN_Subject.None || index < 0 || index >= GetQuestionLength(subject))
            return "";

        switch (subject)
        {
            case AUDIN_Subject.Recebimento:
                return recebimentoQuestions.answers[index];
            case AUDIN_Subject.None:
                return "";
            default:
                return "";
        }
    }

    public bool GetAnswerKey(int index, AUDIN_Subject subject)
    {
        if (subject == AUDIN_Subject.None || index < 0 || index >= GetQuestionLength(subject))
            return false;

        switch (subject)
        {
            case AUDIN_Subject.Recebimento:
                return recebimentoQuestions.answersKeys[index];
            case AUDIN_Subject.None:
                return false;
            default:
                return false;
        }
    }

    #endregion Decode
}
