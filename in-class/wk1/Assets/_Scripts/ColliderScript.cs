using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderScript : MonoBehaviour
{
    private Rigidbody rb;
    public Text countText;

    private int count;

    public Text winText;

    private void Start()
    {
        winText.text = "";
        count = 0;
        SetCountText();
    }

    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("Basket"))
            {
                count = count + 1;
                SetCountText();
            }
            if (count == 4)
            {
                winText.text = "Yummy! Good Job!";
            }
        
    }

    void SetCountText()
    {
    countText.text = "Corn: " + count.ToString();
}



}
