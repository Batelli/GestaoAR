using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodePanel : MonoBehaviour
{
    string gameDeliveryCode = "";

    public GameObject welcomePanel;
    public GameObject inputPanel;
    public GameObject menuPanel;
    public GameObject warningMessage;
    public TMP_Text keyInput;
    public AudioSource panelSFX;


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
        if (gameDeliveryCode.Length == 5 && DeliveryInformationTranslator.Instance.IsTheCodeValid(gameDeliveryCode))
        {
            GameManager.Instance.CreateNewBox(gameDeliveryCode);
            FinalStep();
        }
        else if (gameDeliveryCode.Length == 7 && AudinQuestionTranslator.Instance.IsTheCodeValid(gameDeliveryCode))
        {
            GameManager.Instance.CreateNewAudin(gameDeliveryCode);
            FinalStep();
        }

        if (!warningMessage.activeInHierarchy)
            StartCoroutine(WrongCode()); 
    }

    void FinalStep()
    {
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
        panelSFX.Play();
    }

    public void OpenPanelRecebimento()
    {
        inputPanel.SetActive(true);
        menuPanel.SetActive(false);
        panelSFX.Play();
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
