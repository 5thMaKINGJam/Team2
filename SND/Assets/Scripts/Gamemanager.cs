using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    public InventoryManager inventoryManager;

    public Sprite item1icon;
    public Sprite item2icon;
    public Sprite item3icon;

    private Item item1; //초롱꽃
    private Item item2; //메밀묵
    private Item item3; //수수떡

    void Start()
    {
        item1 = new Item("초롱꽃", item1icon, "환하게 반짝거린다.");
        item2 = new Item("메밀묵", item2icon, "봇짐이 한층 더 고소해졌다.");
        item3 = new Item("수수떡", item3icon, "봇짐이 한층 더 쫀득해졌다.");
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(instance);
        }
    }

    public void OnItemButtonClick(int itemIndex)
    {
        switch (itemIndex)
        {
            case 1:
                inventoryManager.AddItem(item1);  // item1 추가
                break;
            case 2:
                inventoryManager.AddItem(item2);  // item2 추가
                break;
            case 3:
                inventoryManager.AddItem(item3);  // item3 추가
                break;
            default:
                Debug.LogError("아이템 인덱스가 잘못되었습니다.");
                break;
        }
    }
}