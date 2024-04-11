using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CatalogueItem))]
public class CatalogueItemEditor : Editor
{
    CatalogueItem catalogueItem;

    public override void OnInspectorGUI()
    {
        catalogueItem = (CatalogueItem)target;
        EditorUtility.SetDirty(target);

        EditorGUILayout.BeginVertical();

        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        catalogueItem.itemSprite = (Sprite)EditorGUILayout.ObjectField("Sprite", catalogueItem.itemSprite, typeof(Sprite), false);
        
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        catalogueItem.itemCaseType = (ItemCaseType)EditorGUILayout.EnumPopup("Case Type", catalogueItem.itemCaseType);
        catalogueItem.isHospitalItem = EditorGUILayout.Toggle("Hospital", catalogueItem.isHospitalItem);
        catalogueItem.isSchoolItem = EditorGUILayout.Toggle("School", catalogueItem.isSchoolItem);
        catalogueItem.isMuseumItem = EditorGUILayout.Toggle("Museum", catalogueItem.isMuseumItem);
        catalogueItem.isCityHallItem = EditorGUILayout.Toggle("City Hall", catalogueItem.isCityHallItem);

        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        catalogueItem.itemName = (string)EditorGUILayout.TextField("Item", catalogueItem.itemName);
        catalogueItem.itemDescription = (string)EditorGUILayout.TextField("Description", catalogueItem.itemDescription);
        catalogueItem.itemQuantity = EditorGUILayout.IntField("Quantity", catalogueItem.itemQuantity);
        catalogueItem.itemCost = EditorGUILayout.FloatField("Cost", catalogueItem.itemCost);
        
        EditorGUILayout.EndVertical();
    }
}
