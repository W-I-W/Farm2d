using System;
using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private List<Slot> m_Slots;

    private static UIInventory s_Instance;

    private void OnValidate()
    {
        s_Instance = this;
        m_Slots.ForEach(s =>
        {
            s.Image.gameObject.SetActive(false);
            if (s.TextCount == null)
            {
                s.TextCount.gameObject.SetActive(false);
            }
        });
    }

    public static bool TryAdd(ItemData item)
    {
        List<Slot> slots = s_Instance.m_Slots;
        int max = s_Instance.m_Slots.Count;
        int indexFreeSlot = -1;
        bool isAdd = false;

        for (int i = 0; i < max; i++)
        {
            if (indexFreeSlot == -1 && slots[i].ItemData == null)
            {
                indexFreeSlot = i;
            }
            else if (slots[i].ItemData == item && slots[i].Count < item.max)
            {
                Slot slot = slots[i];
                slot.Count++;
                slot.TextCount.text = slot.Count.ToString();
                slots[i] = slot;
                isAdd = true;
                break;
            }
        }

        if (isAdd == false && indexFreeSlot != -1)
        {
            Slot slot = slots[indexFreeSlot];
            slot.Image.gameObject.SetActive(true);
            slot.TextCount.gameObject.SetActive(true);

            slot.Image.sprite = item.icon;
            slot.ItemData = item;
            slot.Count++;
            slot.TextCount.text = slot.Count.ToString();
            slots[indexFreeSlot] = slot;
            isAdd = true;
        }
        return isAdd;
    }
}


[Serializable]
public struct Slot
{
    public Image Image;
    public TextMeshProUGUI TextCount;
    public ItemData ItemData;
    public int Count;
}
