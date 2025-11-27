using NUnit.Framework;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private List<Item> items = new List<Item>();
    [SerializeField] private GameObject buttonContainer;
    [SerializeField] private ItemButtonManager itemButtonManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.Instance.OnItemsMenu += CreateButtons;
    }

    // Update is called once per frame
    private void CreateButtons()
    {
        foreach (var item in items)
        {
            ItemButtonManager itemButton;
            itemButton = Instantiate(itemButtonManager, buttonContainer.transform);
            itemButton.Itemname = item.ItemName;
            itemButton.ItemDesrciption = item.ItemDescription;
            itemButton.itemImage = item.ItemImage;
            itemButton.item3DModel = item.Item3DModel;
            itemButton.name = item.ItemName;
        }

        GameManager.Instance.OnItemsMenu -= CreateButtons;

    }
}
