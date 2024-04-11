using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum BuildingType { Hospital, Museum, School, CityHall, None }
public enum ErrorType { None, Quantity, ItemName, UnitCost, TotalCost, DamagedBox }

//Classe que traz a tradução dos dados importados pelo código numérico
public class DeliveryInformationTranslator : MonoBehaviour
{
    public static DeliveryInformationTranslator Instance { get; private set; }
    
    public CatalogueItem[] itemCatalogue;
    
    int consumptionQtt = 0;
    int perma1Qtt = 0;
    int perma2Qtt = 0;
    int perma3Qtt = 0;

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
        for (int i = 0; i < itemCatalogue.Length; i++)
        {
            switch (itemCatalogue[i].itemCaseType)
            {
                case ItemCaseType.Consumption1:
                    consumptionQtt++;
                    break;
                case ItemCaseType.Permanent1:
                    perma1Qtt++;
                    break;
                case ItemCaseType.Permanent2:
                    perma2Qtt++;
                    break;
                case ItemCaseType.Permanent3:
                    perma3Qtt++;
                    break;
            }
        }
    }
    #endregion Unity

    #region Encode
    public string GenerateCode(BuildingType building, ItemCaseType itemCaseType, int errorChance)
    {
        return GetBuildingCode(building) + GetItemCode(itemCaseType, building) + GetErrorCode(errorChance);
    }

    public string GenerateCodeNoError(string keyCode)
    {
        string newCode = "";

        //Building
        newCode += GetBuildingCode(GetBuildingType(keyCode));

        //Index
        string temp = GetItemIndex(keyCode).ToString("000");
        newCode += GetEncodedChar(temp.Substring(0, 1)) + GetEncodedChar(temp.Substring(1, 1) + GetEncodedChar(temp.Substring(2, 1)));

        //Erro
        newCode += GetErrorCode(0);

        return newCode;
    }

    public bool IsTheCodeValid(string keyCode)
    {
        int index = GetItemIndex(keyCode);
        if (index < 0  ||  index >= itemCatalogue.Length)
            return false;

        return true;
    }

    string GetBuildingCode(BuildingType building) {
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

    string GetItemCode(ItemCaseType itemCaseType, BuildingType building)
    {
        int min = 0;
        int max = 0;

        switch (itemCaseType)
        {
            case ItemCaseType.Consumption1:
                min = 0;
                max = consumptionQtt;
                break;
            case ItemCaseType.Permanent1:
                min = consumptionQtt;
                max = consumptionQtt + perma1Qtt;
                break;
            case ItemCaseType.Permanent2:
                min = consumptionQtt + perma1Qtt;
                max = consumptionQtt + perma1Qtt + perma2Qtt;
                break;
            case ItemCaseType.Permanent3:
                min = consumptionQtt + perma1Qtt + perma2Qtt;
                max = consumptionQtt + perma1Qtt + perma2Qtt + perma3Qtt;
                break;
            case ItemCaseType.PermanentAll:
                min = consumptionQtt;
                max = consumptionQtt + perma1Qtt + perma2Qtt + perma3Qtt;
                break;
            case ItemCaseType.All:
                min = 0;
                max = consumptionQtt + perma1Qtt + perma2Qtt + perma3Qtt;
                break;
        }

        int index = 0;

        do
        {
            index = Random.Range(min, max);
        }
        while (
            (building == BuildingType.Hospital  &&  !itemCatalogue[index].isHospitalItem) ||
            (building == BuildingType.School && !itemCatalogue[index].isSchoolItem) ||
            (building == BuildingType.Museum && !itemCatalogue[index].isMuseumItem) ||
            (building == BuildingType.CityHall && !itemCatalogue[index].isCityHallItem)
            );


        string str = index.ToString("000");
        return GetEncodedChar(str.Substring(0,1)) + GetEncodedChar(str.Substring(1, 1) + GetEncodedChar(str.Substring(2, 1)));
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
            index = Random.Range(1, 6); //Tipo de Erro

        return GetErrorChar(index);
    }

    string GetErrorChar(int errorType)
    {
        string[] strList;

        switch (errorType)
        {
            case 0: //Sem erro
                strList = new string[6] { "K", "U", "5", "F", "1", "S" }; 
                return strList[Random.Range(0, strList.Length)];

            case 1: //Erro de Quantidade
                strList = new string[6] { "B", "V", "6", "P", "H", "3" };
                return strList[Random.Range(0, strList.Length)];

            case 2: //Erro de Valor Total
                strList = new string[6] { "M", "W", "7", "Z", "R", "J" };
                return strList[Random.Range(0, strList.Length)];

            case 3: //Erro de Item errado
                strList = new string[6] { "D", "N", "X", "G", "2", "T" };
                return strList[Random.Range(0, strList.Length)];

            case 4: //Erro de Custo Unitário
                strList = new string[6] { "E", "O", "Y", "9", "Q", "4" };
                return strList[Random.Range(0, strList.Length)];

            case 5: //Caixa Danificada
                strList = new string[5] { "A", "C", "8", "I", "L" };
                return strList[Random.Range(0, strList.Length)];
        }

        return "";

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
        return GetDecodedIndex(keyCode.Substring(3, 1)) + (GetDecodedIndex(keyCode.Substring(2, 1)) * 10) + (GetDecodedIndex(keyCode.Substring(1, 1)) * 100);
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

    public ErrorType GetErrorType(string keyCode)
    {
        switch (keyCode.Substring(4, 1)) 
        {
            case "B":
            case "V":
            case "6":
            case "P":
            case "H":
            case "3":
                return ErrorType.Quantity;

            case "M":
            case "W":
            case "7":
            case "Z":
            case "R":
            case "J":
                return ErrorType.TotalCost;

            case "D":
            case "N":
            case "X":
            case "G":
            case "2":
            case "T":
                return ErrorType.ItemName;

            case "E":
            case "O":
            case "Y":
            case "9":
            case "Q":
            case "4":
                return ErrorType.UnitCost;

            case "A":
            case "C":
            case "8":
            case "I":
            case "L":
                return ErrorType.DamagedBox;
            
            default:
                return ErrorType.None;
        }
    }

    public string GetObjectName (string keyCode)
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
                if (index < itemCatalogue.Length - 4)
                    index += 3;
                else
                    index -= 3;
                break;

            case "G":
                if (index > 0)
                    index -= 1;
                else
                    index += 1;
                break;

            case "2":
                if (index > 1)
                    index -= 2;
                else
                    index += 2;
                break;

            case "T":
                if (index > 2)
                    index -= 3;
                else
                    index += 3;
                break;
        }

        return itemCatalogue[index].itemName;
    }

    public string GetObjectDescription (string keyCode)
    {
        int index = GetItemIndex(keyCode);
        return itemCatalogue[index].itemDescription;
    }

    public string GetUnitQtt (string keyCode)
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
                if (qtt > 1)
                    qtt -= 1;
                else
                    qtt += 1;
                break;

            case "6":
                if (qtt > 5)
                    qtt -= 5;
                else
                    qtt += 5;
                break;

            case "P":
                if (qtt > 10)
                    qtt -= 10;
                else
                    qtt += 10;
                break;

            case "H":
                if (qtt > 25)
                    qtt -= 25;
                else
                    qtt += 25;
                break;

            case "3":
                if (qtt > 100)
                    qtt -= 100;
                else
                    qtt += 100;
                break;
        }

        return qtt.ToString();
    }

    public string GetUnitCost (string keyCode)
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
                if (cost > 1f)
                    cost -= 0.5f;
                else
                    cost += 0.5f;
                break;

            case "Y":
                if (cost > 1.5f)
                    cost -= 1f;
                else
                    cost += 1f;
                break;

            case "9":
                if (cost > 5f)
                    cost -= 4.5f;
                else
                    cost += 4.5f;
                break;

            case "Q":
                if (cost > 15f)
                    cost -= 14.5f;
                else
                    cost += 14.5f;
                break;

            case "4":
                if (cost > 50f)
                    cost -= 45f;
                else
                    cost += 45f;
                break;
        }

        return cost.ToString("0.00");
    }

    public string GetTotalCost (string keyCode)
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
                totalCost *= 0.1f;
                break;

            case "7":
                totalCost *= 0.5f;
                break;

            case "Z":
                totalCost *= 2f;
                break;

            case "R":
                totalCost *= 5f;
                break;

            case "J":
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
    #endregion Decode
}