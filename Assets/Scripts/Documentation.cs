using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Documentation : MonoBehaviour
{
    public TextMeshProUGUI documentationPainting;
    private bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!isActive)
        {
            documentationPainting.gameObject.SetActive(true);
            isActive = true;
        }
        else
        {
            documentationPainting.gameObject.SetActive(false);
            isActive = false;
        }
    }
}
