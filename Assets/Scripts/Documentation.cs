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

    /*    private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Entrée dans Venus");
            if (collision.gameObject.CompareTag("Visiteur"))
            {
                Debug.Log("Entrée dans Venus");
                documentationPainting.gameObject.SetActive(true);
                isActive = true;
            }
        }*/

    /*private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Sortie de Venus");
        if (collision.gameObject.CompareTag("Venus"))
        {
            documentationPainting.gameObject.SetActive(false);
            isActive = false;
        }
    }*/

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Venus"))
        {
            // Debug.Log("Entrée dans Venus");
            documentationPainting.gameObject.SetActive(true);
            isActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Sortie de Venus");
    }
}
