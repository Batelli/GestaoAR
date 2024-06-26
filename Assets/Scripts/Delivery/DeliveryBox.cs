using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Classe referente a caixa / o pacote de entrega e as informações de documentos e da caixa
public class DeliveryBox : MonoBehaviour
{
    public GameObject oldBox;
    public GameObject newBox;

    public TMP_Text nfNumber;
    public TMP_Text providerName;
    public TMP_Text receiverName;
    public TMP_Text objectName;
    public TMP_Text objectDescription;
    public TMP_Text unitQttNumber;
    public TMP_Text unitCostNumber;
    public TMP_Text totalCostNumber;
    public TMP_Text deliveryDate;
    public TMP_Text shoppingDate;
    public TMP_Text measureType;
    public TMP_Text expirationDateText;
    public GameObject[] nfBuildingIcon;
    public GameObject expirationDate;

    public TMP_Text boxNFNumber;
    public TMP_Text boxObjectName;
    public TMP_Text boxQtt;
    public GameObject[] boxBuildingIcon;



    private void Awake()
    {
        oldBox.SetActive(false);
        newBox.SetActive(false);
    }

    public void LoadBox(string codeToTranslate)
    {
        nfNumber.text = codeToTranslate.ToUpper();
        providerName.text = DeliveryInformationTranslator.Instance.GetCompanyName(codeToTranslate).ToUpper();
        receiverName.text = DeliveryInformationTranslator.Instance.GetBuildingName(codeToTranslate).ToUpper();
        objectName.text = DeliveryInformationTranslator.Instance.GetObjectName(codeToTranslate).ToUpper();
        objectDescription.text = DeliveryInformationTranslator.Instance.GetObjectDescription(codeToTranslate).ToUpper();
        unitQttNumber.text = DeliveryInformationTranslator.Instance.GetUnitQtt(codeToTranslate);
        unitCostNumber.text = DeliveryInformationTranslator.Instance.GetUnitCost(codeToTranslate);
        totalCostNumber.text = DeliveryInformationTranslator.Instance.GetTotalCost(codeToTranslate);
        deliveryDate.text = DeliveryInformationTranslator.Instance.GetDeliveryDate(codeToTranslate);
        shoppingDate.text = DeliveryInformationTranslator.Instance.GetCurrentDate();
        measureType.text = DeliveryInformationTranslator.Instance.GetMeasureType(codeToTranslate);
        expirationDate.SetActive(DeliveryInformationTranslator.Instance.GetExpirationDate(codeToTranslate));
        expirationDateText.text = DeliveryInformationTranslator.Instance.GetProductionDate(codeToTranslate);

        boxNFNumber.text = codeToTranslate.ToUpper();
        boxObjectName.text = DeliveryInformationTranslator.Instance.GetObjectName(codeToTranslate).ToUpper();
        boxQtt.text = DeliveryInformationTranslator.Instance.GetUnitQtt(codeToTranslate)+"X";

        int temp = (int)DeliveryInformationTranslator.Instance.GetBuildingType(codeToTranslate);
        boxBuildingIcon[temp].SetActive(true);
        nfBuildingIcon[temp].SetActive(true);

        bool damagedBox = DeliveryInformationTranslator.Instance.GetDamagedBox(codeToTranslate);
        oldBox.SetActive(damagedBox);
        newBox.SetActive(!damagedBox);
    }
}
