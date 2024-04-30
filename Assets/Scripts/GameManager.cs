using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameObject boxPrefab;
    public GameObject audinPrefab;
    public GameObject audinChar;


    private void Awake()
    {
        //Singleton
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    public void CreateNewBox(string newCode)
    {
        Vector3 newPos = Camera.main.transform.position + (Camera.main.transform.forward * 1.2f);
        RaycastHit hitInfo;
        if (!Physics.Raycast(newPos, Vector3.down, out hitInfo, 10))
        {
            Debug.Log("Floor not found");
            return;
        }

        newPos += Vector3.up;
        GameObject gmo = Instantiate(boxPrefab, newPos, Quaternion.identity) as GameObject;
        Vector3 rot = gmo.transform.eulerAngles;
        rot.y = Random.Range(0, 360);
        gmo.transform.eulerAngles = rot;

        //Configurando a Caixa
        DeliveryBox box = gmo.GetComponent<DeliveryBox>();
        if (box)
        {
            box.LoadBox(newCode);
        }
        else
        {
            Destroy(gmo);
        }
    }

    public void CreateNewAudin(string newCode)
    {
        Vector3 newPos = Camera.main.transform.position + (Camera.main.transform.forward * 0.8f);
        RaycastHit hitInfo;
        if (!Physics.Raycast(newPos, Vector3.down, out hitInfo, 10))
        {
            Debug.Log("Floor not found");
            return;
        }

        newPos += Vector3.up;
        GameObject gmo = Instantiate(audinPrefab, newPos, Quaternion.identity) as GameObject;
        Vector3 rot = gmo.transform.eulerAngles;
        rot.y = Random.Range(0, 360);
        gmo.transform.eulerAngles = rot;

        //Configurando a Nota
        AudinNote note = gmo.GetComponent<AudinNote>();
        if (note)
        {
            note.LoadNote(newCode);
            audinChar.SetActive(true);
        }
        else
        {
            Destroy(gmo);
        }
    }
}
