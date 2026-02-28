using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    
    [SerializeField] Text textActivate;

    [SerializeField] GameObject Laptop_white;
    [SerializeField] GameObject Laptop_white_off;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        UpdateText();
    }

    void UpdateText()
    {
        

    }



    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Comp"))
        {
            textActivate.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                Laptop_white.gameObject.SetActive(true);
                Laptop_white_off.gameObject.SetActive(false);
                textActivate.gameObject.SetActive(false);
                Destroy(other.gameObject);
              
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        textActivate.gameObject.SetActive(false); Laptop_white.gameObject.SetActive(false);
    }
}
