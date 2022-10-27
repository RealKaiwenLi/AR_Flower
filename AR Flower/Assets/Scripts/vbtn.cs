using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using UnityEngine;

public class vbtn : MonoBehaviour
{
    public GameObject cube;
    public Button btn;
    
    // Start is called before the first frame update
    void Start()
    {
        cube.SetActive(false);
        btn = GetComponent<Button>();
        btn.onClick.AddListener(SelectObject);
    }

    void SelectObject(){
        cube.SetActive(true);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
