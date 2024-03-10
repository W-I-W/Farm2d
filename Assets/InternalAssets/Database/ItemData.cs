using System.Collections;
using System.Collections.Generic;

using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Database/Item", order = 10)]
public class ItemData : ScriptableObject
{
    [SerializeField] private Sprite m_Icon;
    [SerializeField] private string m_ItemName = "";
    [SerializeField, TextArea] private string m_Description = "";
    [SerializeField] private int m_Max = 100;
    [SerializeField] private int m_Id = 0;


    public Sprite icon { get => m_Icon; }

    public new string name { get => m_ItemName; }

    public string description { get => m_Description; }

    public int max { get => m_Max; }

    public int id { get => m_Id; }

}
