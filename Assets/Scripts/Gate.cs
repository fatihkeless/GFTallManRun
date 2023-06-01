using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gate : MonoBehaviour
{
    public int count;
    public Text countText;
    public Transform gateSpawnPos;
    public bool height;
    public Image arrow;
    public Image arrowUp;
    public Material greenMat;
    public Material redMat;
    public Image upImage;
    public Color blueColor;
    public Color redColor;
    


    // Start is called before the first frame update
    void Start()
    {
        if(count > 0)
        {
            countText.text = "+" + count.ToString();
            transform.GetChild(0).gameObject.GetComponent<Renderer>().material = greenMat;
            upImage.color = blueColor;
        }
        else
        {
            countText.text =   count.ToString();
            transform.GetChild(0).gameObject.GetComponent<Renderer>().material = redMat;
            upImage.color = redColor;
        }
        if (height)
        {
            arrowUp.gameObject.SetActive(true);
            arrow.gameObject.SetActive(false);
        }
        else
        {
            arrowUp.gameObject.SetActive(false);
            arrow.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (height)
            {
                if (count > 0)
                {
                    other.gameObject.GetComponent<Player>().AddHeight(2);
                }
                else
                {
                    other.gameObject.GetComponent<Player>().AddHeight(-2);
                }
            }
            else
            {
                if (count > 0)
                {
                    other.gameObject.GetComponent<Player>().AddWidth(1);
                }
                else
                {
                    other.gameObject.GetComponent<Player>().AddWidth(-1);
                }
            }
            
        }
    }

}
