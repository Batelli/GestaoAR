using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Catalogue Item")]
public class CatalogueItem : ScriptableObject
{
    public Sprite itemSprite;
    public ItemCaseType itemCaseType;
    public string itemName;
    public string itemDescription;
    public int itemQuantity;
    public MeasureType itemMeasureType;
    public float itemCost;
    public bool isHospitalItem;
    public bool isSchoolItem;
    public bool isMuseumItem;
    public bool isCityHallItem;
}
