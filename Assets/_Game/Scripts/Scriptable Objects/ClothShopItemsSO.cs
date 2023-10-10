using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cloth Shop Items xxx", menuName = "ScriptableObjects/Shop/Cloth Shop Item List")]
public class ClothShopItemsSO : ScriptableObject
{
    public List<ShopItemSO> List;
}
