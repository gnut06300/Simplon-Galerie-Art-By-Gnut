using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Documentation : MonoBehaviour
{
    public TextMeshProUGUI documentationPainting;
    private Image crossImage;
    private bool isActive;
    private bool crossIsActive;

    // Start is called before the first frame update
    void Start()
    {
        crossImage = GameObject.Find("ImageCross").GetComponent<Image>();
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

    private void OnMouseEnter()
    {
        // crossImage.enabled = true;
        crossImage.color = new Color(0.9433962f, 0.5311463f, 0.04805973f);
    }

    private void OnMouseExit()
    {
        // crossImage.enabled = false;
        crossImage.color = new Color(1f, 1f, 1f);
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
            Debug.Log("Entrée dans Venus");
            documentationPainting.gameObject.SetActive(true);
            isActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Sortie de Venus");
    }
}
