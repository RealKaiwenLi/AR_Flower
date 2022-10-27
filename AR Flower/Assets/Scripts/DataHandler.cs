using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class DataHandler : MonoBehaviour
{
    private GameObject furniture;

    public RectTransform ParentPanel;
    public GameObject prefabButton;

    // [SerializeField] private String label;    
    

    private int currrent_id = 0;

        private static DataHandler instance;
    public static DataHandler Instance 
    {
        get
        {
            if(instance==null)
            {
                instance = FindObjectOfType<DataHandler>();
            }
            return instance;
        }
    }


    private void Start() {
        // items = new List<Item>();
        LoadItems();
        // await Get(label);
        CreateButtons();
    }

    void LoadItems()
    {
        // var item_obj = Resources.LoadAll("flowers",typeof(Item));
        // foreach (var item in item_obj)
        // {
        //     items.Add(item as Item);
        // }
    }

    void CreateButtons()
    {
        for(int i = 0; i < 5; i++)
        {
            GameObject goButton = (GameObject)Instantiate(prefabButton);
            goButton.transform.SetParent(ParentPanel, false);
            goButton.transform.localScale = new Vector3(1, 1, 1);
           
            Button tempButton = goButton.GetComponent<Button>();
            int tempInt = i;
           
            tempButton.onClick.AddListener(() => ButtonClicked(tempInt));
        }
    }

    void ButtonClicked(int buttonNo)
    {
        Debug.Log ("Button clicked = " + buttonNo);
    }

    public void SetFurniture(int id)
    {
        // furniture = items[id].itemPrefab;
    }

    public GameObject GetFurniture()
    {
        return furniture;
    }

    // public async Task Get(String label)
    // {
    //     var locations = await Addressables.LoadResourceLocationsAsync(label).Task;
    //     foreach (var location in locations)
    //     {
    //         var obj = await Addressables.LoadAssetAsync<Item>(location).Task;
    //         items.Add(obj);
    //     }
    // }

}

