using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public enum BuildingType { Hospital, Museum, School, CityHall, None }
public enum ErrorType { None, Quantity, ItemName, UnitCost, TotalCost, DamagedBox, Description, MeasureType, DeliveryDate, ExpirationDate }
public enum ItemCaseType { Consumption1, Permanent1, Permanent2, Permanent3, PermanentAll, All }
public enum MeasureType
{
    Unidade,
    Pacote_100g, Pacote_500g, Pacote_1KG,
    Pacote_12_Unidades, Pacote_50_Unidades, Pacote_72_Unidades, Pacote_100_Unidades,
    Pacote_200_Unidades, Pacote_250_Unidades, Pacote_500_Unidades,
    Caixa_12_Folhas,
    Garrafao_20L,
    Frasco_18mL, Frasco_250mL, Frasco_500mL, Frasco_1L,
    Rolo_450cm, Rolo_10m, Rolo_25m, Rolo_50m, Rolo_250g,
    Bloco_100_folhas, Bloco_200_folhas,
    Tubo_6_Unidades, Tubo_12_Unidades
}


//Classe que traz a tradução dos dados importados pelo código numérico
public class DeliveryInformationTranslator : MonoBehaviour
{
    public static DeliveryInformationTranslator Instance { get; private set; }
    public CatalogueItem[] itemCatalogue;

    /*      O código dos itens é composto por 5 dígitos alfanuméricos (1-9, A-Z)
                                    X YYY Z
            O primeiro valor, X, indica o tipo de construção
            Os 3 próximos valores, YYY, indicam qual o item
            O valor final, Z, indica se há algum erro com o pedido
    */


    #region Unity
    private void Awake()
    {
        //Singleton
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    private void Start()
    {
        itemCatalogue = Resources.LoadAll<CatalogueItem>("CatalogueItems");
    }
    #endregion Unity

    #region Encode
    public string GenerateCode(BuildingType building, int errorChance)
    {
        return GetBuildingCode(building) + GetItemCode(building) + GetErrorCode(errorChance);
    }

    public string GenerateCodeNoError(string keyCode)
    {
        string newCode = "";

        //Building
        newCode += GetBuildingCode(GetBuildingType(keyCode));

        //Index
        string temp = GetItemIndex(keyCode).ToString("000");
        newCode += GetEncodedChar(temp.Substring(0, 1)) + GetEncodedChar(temp.Substring(1, 1)) + GetEncodedChar(temp.Substring(2, 1));

        //Erro
        newCode += GetErrorCode(0);

        return newCode;
    }

    public bool IsTheCodeValid(string keyCode)
    {
        int index = GetItemIndex(keyCode);
        if (index < 0 || index >= itemCatalogue.Length)
            return false;

        return true;
    }

    string GetBuildingCode(BuildingType building)
    {
        string[] strList;

        switch (building)
        {
            case BuildingType.Hospital:
                strList = new string[8] { "A", "E", "I", "M", "Q", "U", "Y", "3" };
                return strList[Random.Range(0, strList.Length)];
            case BuildingType.Museum:
                strList = new string[8] { "B", "F", "J", "N", "R", "V", "Z", "4" };
                return strList[Random.Range(0, strList.Length)];
            case BuildingType.School:
                strList = new string[8] { "C", "G", "K", "O", "S", "W", "1", "5" };
                return strList[Random.Range(0, strList.Length)];
            case BuildingType.CityHall:
                strList = new string[8] { "D", "H", "L", "P", "T", "X", "2", "6" };
                return strList[Random.Range(0, strList.Length)];
        }

        return "";
    }

    string GetItemCode(BuildingType building)
    {
        int index = 0;

        switch (building)
        {
            case BuildingType.Museum:
                do index = Random.Range(0, itemCatalogue.Length);
                while (!itemCatalogue[index].isMuseumItem);
                break;

            case BuildingType.Hospital:
                do index = Random.Range(0, itemCatalogue.Length);
                while (!itemCatalogue[index].isHospitalItem);
                break;

            case BuildingType.School:
                do index = Random.Range(0, itemCatalogue.Length);
                while (!itemCatalogue[index].isSchoolItem);
                break;

            case BuildingType.CityHall:
                do index = Random.Range(0, itemCatalogue.Length);
                while (!itemCatalogue[index].isCityHallItem);
                break;
        }

        string str = index.ToString("000");
        string newCode = GetEncodedChar(str.Substring(0, 1)) + GetEncodedChar(str.Substring(1, 1)) + GetEncodedChar(str.Substring(2, 1));
        return newCode;
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

    string GetErrorCode(int errorChance)
    {
        int index = 0; //Sem erro
        int rand = Random.Range(0, 100);

        if (rand < errorChance)
            index = Random.Range(1, System.Enum.GetValues(typeof(ErrorType)).Length); //Tipo de Erro

        return GetErrorChar(index);
    }

    string GetErrorChar(int errorType)
    {
        string[] strList = new string[1] { "" };

        switch (errorType)
        {
            case 0: //Sem erro
                strList = new string[4] { "K", "U", "5", "F" };
                break;

            case 1: //Erro de Quantidade
                strList = new string[4] { "B", "V", "6", "P" };
                break;

            case 2: //Erro de Valor Total
                strList = new string[4] { "M", "W", "7", "Z" };
                break;

            case 3: //Erro de Item errado
                strList = new string[4] { "D", "N", "X", "G" };
                break;

            case 4: //Erro de Custo Unitário
                strList = new string[4] { "E", "O", "Y", "9" };
                break;

            case 5: //Caixa Danificada
                strList = new string[3] { "A", "C", "8", };
                break;

            case 6: //Descricao
                strList = new string[3] { "1", "S", "2" };
                break;

            case 7: //Unidade de Medida
                strList = new string[3] { "H", "3", "L" };
                break;

            case 8: //Data de Entrega
                strList = new string[3] { "R", "J", "Q" };
                break;

            case 9: //Data de Validade
                strList = new string[3] { "T", "I", "4" };
                break;
        }

        return strList[Random.Range(0, strList.Length)];

    }
    #endregion Encode

    #region Decode
    public string GetCompanyName(string keyCode)
    {
        return "Empresa Temporária LTDA";
    } //Falta fazer ------------------------------------------------

    public BuildingType GetBuildingType(string keyCode)
    {
        switch (keyCode.Substring(0, 1))
        {
            case "A":
            case "E":
            case "I":
            case "M":
            case "Q":
            case "U":
            case "Y":
            case "3":
                return BuildingType.Hospital;
            case "B":
            case "F":
            case "J":
            case "N":
            case "R":
            case "V":
            case "Z":
            case "4":
                return BuildingType.Museum;
            case "C":
            case "G":
            case "K":
            case "O":
            case "S":
            case "W":
            case "1":
            case "5":
                return BuildingType.School;
            case "D":
            case "H":
            case "L":
            case "P":
            case "T":
            case "X":
            case "2":
            case "6":
                return BuildingType.CityHall;
        }

        return BuildingType.None;
    }

    public string GetBuildingName(string keyCode)
    {
        switch (keyCode.Substring(0, 1))
        {
            case "A":
            case "E":
            case "I":
            case "M":
            case "Q":
            case "U":
            case "Y":
            case "3":
                return "Hospital";
            case "B":
            case "F":
            case "J":
            case "N":
            case "R":
            case "V":
            case "Z":
            case "4":
                return "Museu";
            case "C":
            case "G":
            case "K":
            case "O":
            case "S":
            case "W":
            case "1":
            case "5":
                return "Escola";
            case "D":
            case "H":
            case "L":
            case "P":
            case "T":
            case "X":
            case "2":
            case "6":
                return "Prefeitura";
        }

        return "";
    }

    public int GetItemIndex(string keyCode)
    {
        int index = GetDecodedIndex(keyCode.Substring(3, 1)) + (GetDecodedIndex(keyCode.Substring(2, 1)) * 10) + (GetDecodedIndex(keyCode.Substring(1, 1)) * 100);
        return index;
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

    ItemCaseType GetItemCaseType(string keyCode)
    {
        int index = GetItemIndex(keyCode);
        return itemCatalogue[index].itemCaseType;
    }

    public ErrorType GetErrorType(string keyCode)
    {
        switch (keyCode.Substring(4, 1))
        {
            case "B":
            case "V":
            case "6":
            case "P":
                return ErrorType.Quantity;

            case "M":
            case "W":
            case "7":
            case "Z":
                return ErrorType.TotalCost;

            case "D":
            case "N":
            case "X":
            case "G":
                return ErrorType.ItemName;

            case "E":
            case "O":
            case "Y":
            case "9":
                return ErrorType.UnitCost;

            case "A":
            case "C":
            case "8":
                return ErrorType.DamagedBox;

            case "1":
            case "S":
            case "2":
                return ErrorType.Description;

            case "H":
            case "3":
            case "L":
                return ErrorType.MeasureType;

            case "R":
            case "J":
            case "Q":
                return ErrorType.DeliveryDate;

            case "T":
            case "I":
            case "4":
                return ErrorType.ExpirationDate;

            default:
                return ErrorType.None;
        }
    }

    public string GetObjectName(string keyCode)
    {
        ErrorType error = GetErrorType(keyCode);
        int index = GetItemIndex(keyCode);

        if (error != ErrorType.ItemName)
            return itemCatalogue[index].itemName;

        string str = keyCode.Substring(4, 1);
        switch (str)
        {
            case "D":
                if (index < itemCatalogue.Length - 2)
                    index += 1;
                else
                    index -= 1;
                break;

            case "N":
                if (index < itemCatalogue.Length - 3)
                    index += 2;
                else
                    index -= 2;
                break;

            case "X":
                if (index > 0)
                    index -= 1;
                else
                    index += 1;
                break;

            case "G":
                if (index > 1)
                    index -= 2;
                else
                    index += 2;
                break;
        }

        return itemCatalogue[index].itemName;
    }

    public string GetObjectDescription(string keyCode)
    {
        ErrorType error = GetErrorType(keyCode);
        int index = GetItemIndex(keyCode);

        if (error != ErrorType.Description)
            return itemCatalogue[index].itemDescription;

        string str = keyCode.Substring(4, 1);
        switch (str)
        {
            case "1":
                if (index < itemCatalogue.Length - 2)
                    index += 1;
                else
                    index -= 1;
                break;

            case "S":
                if (index < itemCatalogue.Length - 3)
                    index += 2;
                else
                    index -= 2;
                break;

            case "2":
                if (index > 0)
                    index -= 1;
                else
                    index += 1;
                break;

            case "T":
                if (index > 1)
                    index -= 2;
                else
                    index += 2;
                break;
        }

        return itemCatalogue[index].itemDescription;
    }

    public string GetUnitQtt(string keyCode)
    {
        ErrorType error = GetErrorType(keyCode);
        int index = GetItemIndex(keyCode);
        int qtt = itemCatalogue[index].itemQuantity;

        if (error != ErrorType.Quantity)
            return qtt.ToString();

        string str = keyCode.Substring(4, 1);
        switch (str)
        {
            case "B":
                qtt = 0;
                break;

            case "V":
                if (qtt > 5)
                    qtt -= 5;
                else
                    qtt += 5;
                break;

            case "6":
                if (qtt > 25)
                    qtt -= 25;
                else
                    qtt += 25;
                break;

            case "P":
                if (qtt > 100)
                    qtt -= 100;
                else
                    qtt += 100;
                break;
        }

        return qtt.ToString();
    }

    public string GetUnitCost(string keyCode)
    {
        ErrorType error = GetErrorType(keyCode);
        int index = GetItemIndex(keyCode);
        float cost = itemCatalogue[index].itemCost;

        if (error != ErrorType.UnitCost)
            return cost.ToString("0.00");

        string str = keyCode.Substring(4, 1);
        switch (str)
        {
            case "E":
                cost = 0;
                break;

            case "O":
                if (cost > 2f)
                    cost -= 1f;
                else
                    cost += 1f;
                break;

            case "Y":
                if (cost > 11f)
                    cost -= 10f;
                else
                    cost += 10f;
                break;

            case "9":
                if (cost > 50f)
                    cost -= 45f;
                else
                    cost += 45f;
                break;
        }

        return cost.ToString("0.00");
    }

    public string GetTotalCost(string keyCode)
    {
        ErrorType error = GetErrorType(keyCode);
        int index = GetItemIndex(keyCode);
        float totalCost = itemCatalogue[index].itemCost * (float)itemCatalogue[index].itemQuantity;

        if (error != ErrorType.TotalCost)
            return totalCost.ToString("0.00");

        string str = keyCode.Substring(4, 1);
        switch (str)
        {
            case "M":
                totalCost = 0f;
                break;

            case "W":
                totalCost *= 0.5f;
                break;

            case "7":
                totalCost *= 5f;
                break;

            case "Z":
                totalCost *= 10f;
                break;
        }

        return totalCost.ToString("0.00");
    }

    public bool GetDamagedBox(string keyCode)
    {
        ErrorType error = GetErrorType(keyCode);
        return (error == ErrorType.DamagedBox);
    }

    public string GetMeasureType(string keyCode)
    {
        ErrorType error = GetErrorType(keyCode);
        MeasureType measure = itemCatalogue[GetItemIndex(keyCode)].itemMeasureType;

        if (error != ErrorType.MeasureType)
            return GetMeasureTypeText(measure);


        int maxQtt = System.Enum.GetValues(typeof(MeasureType)).Length;
        MeasureType measureType;

        do
        {
            measureType = (MeasureType)Random.Range(0, maxQtt);
        }
        while (measureType == measure);

        return GetMeasureTypeText(measureType);
    }

    public string GetMeasureTypeNoError(string keyCode)
    {
        return GetMeasureTypeText(itemCatalogue[GetItemIndex(keyCode)].itemMeasureType);
    }

    string GetMeasureTypeText(MeasureType measureType)
    {
        switch (measureType)
        {
            case MeasureType.Unidade:
                return "Unidade";

            case MeasureType.Pacote_100g:
                return "Pacote de 100g";

            case MeasureType.Pacote_500g:
                return "Pacote de 500g";

            case MeasureType.Pacote_1KG:
                return "Pacote de 1KG";

            case MeasureType.Pacote_12_Unidades:
                return "Pacote de 12 Unidades";

            case MeasureType.Pacote_50_Unidades:
                return "Pacote de 50 Unidades";

            case MeasureType.Pacote_72_Unidades:
                return "Pacote de 72 Unidades";

            case MeasureType.Pacote_100_Unidades:
                return "Pacote de 100 Unidades";

            case MeasureType.Pacote_200_Unidades:
                return "Pacote de 200 Unidades";

            case MeasureType.Pacote_250_Unidades:
                return "Pacote de 250 Unidades";

            case MeasureType.Pacote_500_Unidades:
                return "Pacote de 500 Unidades";

            case MeasureType.Caixa_12_Folhas:
                return "Caixa c/ 12 Folhas";

            case MeasureType.Garrafao_20L:
                return "Garrafão de 20L";

            case MeasureType.Frasco_18mL:
                return "Frasco de 18mL";

            case MeasureType.Frasco_250mL:
                return "Frasco de 250mL";

            case MeasureType.Frasco_500mL:
                return "Frasco de 500mL";

            case MeasureType.Frasco_1L:
                return "Frasco de 1L";

            case MeasureType.Rolo_450cm:
                return "Rolo de 4,5m";

            case MeasureType.Rolo_10m:
                return "Rolo de 10m";

            case MeasureType.Rolo_25m:
                return "Rolo de 25m";

            case MeasureType.Rolo_50m:
                return "Rolo de 50m";

            case MeasureType.Rolo_250g:
                return "Rolo de 250g";

            case MeasureType.Bloco_100_folhas:
                return "Bloco de 100 Folhas";

            case MeasureType.Bloco_200_folhas:
                return "Bloco de 200 Folhas";

            case MeasureType.Tubo_6_Unidades:
                return "Tubo com 6 Unidades";

            case MeasureType.Tubo_12_Unidades:
                return "Tubo com 12 Unidades";

            default:
                return "Unidade";
        }
    }

    public string GetDeliveryDate(string keyCode)
    {
        ErrorType error = GetErrorType(keyCode);
        System.DateTime dateTime = System.DateTime.Now;
        dateTime = dateTime.AddDays(Random.Range(10, 20)); //entrega de 10 a 20 dias

        if (error != ErrorType.DeliveryDate)
            return dateTime.ToString("dd/MM/yyyy");


        dateTime = dateTime.AddDays(Random.Range(25, 45)); //entrega acima de 30 dias
        return dateTime.ToString("dd/MM/yyyy");
    }

    public string GetDeliveryDateNoError()
    {
        System.DateTime dateTime = System.DateTime.Now;
        dateTime = dateTime.AddDays(Random.Range(5, 15)); //entrega de 5 a 15 dias
        return dateTime.ToString("dd/MM/yyyy");
    }

    public string GetCurrentDate()
    {
        return System.DateTime.Now.ToString("dd/MM/yyyy");
    }

    public string GetDeliveryDeadline(string keyCode)
    {
        System.DateTime dateTime = System.DateTime.Now;
        dateTime = dateTime.AddDays(20);
        return dateTime.ToString("dd/MM/yyyy");
    }

    public string GetProductionDate(string keyCode)
    {
        System.DateTime dateTime = System.DateTime.Now;

        if (GetErrorType(keyCode) != ErrorType.ExpirationDate)
            dateTime = dateTime.AddDays(-Random.Range(60, 450));
        else
            dateTime = dateTime.AddDays(Random.Range(800, 1500));

        return dateTime.ToString("dd/MM/yyyy");
    }

    public bool GetExpirationDate (string keyCode)
    {
        if (GetItemCaseType(keyCode) == ItemCaseType.Consumption1)
            return true;
        
        return false;
    }
    #endregion Decode
}