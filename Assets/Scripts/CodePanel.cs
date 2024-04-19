using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum CaseSelection { None, Recebimento, Audin }


public class CodePanel : MonoBehaviour
{
    string gameDeliveryCode = "";

    public GameObject welcomePanel;
    public GameObject inputPanel;
    public GameObject menuPanel;
    public GameObject warningMessage;
    public TMP_Text keyInput;
    public TMP_Text initialCommand;
    CaseSelection selection = CaseSelection.None;


    private void Start()
    {
        keyInput.text = "";
        warningMessage.SetActive(false);
        inputPanel.SetActive(false);
        menuPanel.SetActive(false);
        welcomePanel.SetActive(true);
    }

    public void GetNewInput(string str)
    {
        gameDeliveryCode += str;
        gameDeliveryCode = gameDeliveryCode.ToUpper();
        UpdateText();
    }

    public void GetEnterInput()
    {
        if (selection == CaseSelection.Recebimento)
        {
            if (gameDeliveryCode.Length != 5 || !DeliveryInformationTranslator.Instance.IsTheCodeValid(gameDeliveryCode))
            {
                if (!warningMessage.activeInHierarchy)
                    StartCoroutine(WrongCode());

                return;
            }

            GameManager.Instance.CreateNewBox(gameDeliveryCode);
        }
        else if (selection == CaseSelection.Audin) 
        {
            if (gameDeliveryCode.Length != 7 || !AudinQuestionTranslator.Instance.IsTheCodeValid(gameDeliveryCode))
            {
                if (!warningMessage.activeInHierarchy)
                    StartCoroutine(WrongCode());

                return;
            }

            GameManager.Instance.CreateNewAudin(gameDeliveryCode);
        }

        
        gameDeliveryCode = "";
        UpdateText();
        ClosePanel();
    }

    public void GetDeleteInput()
    {
        gameDeliveryCode = gameDeliveryCode.Remove(gameDeliveryCode.Length-1);
        UpdateText();
    }

    public void ClosePanel()
    {
        inputPanel.SetActive(false);
        menuPanel.SetActive(true);
        selection = CaseSelection.None;
    }

    public void OpenPanelRecebimento()
    {
        inputPanel.SetActive(true);
        menuPanel.SetActive(false);
        selection = CaseSelection.Recebimento;
        initialCommand.text = "Insira o código informado na mesa para Receber o Item";
    }

    public void OpenPanelAudin()
    {
        inputPanel.SetActive(true);
        menuPanel.SetActive(false);
        selection = CaseSelection.Audin;
        initialCommand.text = "Insira o código informado na mesa para resolver a AUDIN";
    }

    public void CloseWelcomeMessage()
    {
        welcomePanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    void UpdateText()
    {
        keyInput.text = gameDeliveryCode;
    }

    IEnumerator WrongCode()
    {
        warningMessage.SetActive(true);
        yield return new WaitForSeconds(2);
        warningMessage.SetActive(false);
    }
}
