using CharacterCustomization.Controllers;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopItem", menuName = "ScriptableObjects/Shop/ShopItem")]
public class ShopItemSO : ScriptableObject
{
    public ClothesItemTypes ItemType;
    public string ItemName;
    public int Price;
    public Sprite Sprite;
}
