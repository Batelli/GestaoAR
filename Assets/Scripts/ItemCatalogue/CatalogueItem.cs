using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemCaseType { Consumption1, Permanent1, Permanent2, Permanent3, PermanentAll, All }

[CreateAssetMenu(menuName="Catalogue Item")]
public class CatalogueItem : ScriptableObject
{
    public Sprite itemSprite;
    public ItemCaseType itemCaseType;
    public string itemName;
    public string itemDescription;
    public int itemQuantity;
    public float itemCost;
    public bool isHospitalItem;
    public bool isSchoolItem;
    public bool isMuseumItem;
    public bool isCityHallItem;
}
