using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIAnim : MonoBehaviour
{
    GameObject target;
    bool destroy;
    bool move;
    public GameManager gameManager;
    public bool gold;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameManager>();
        
        target = gameManager.gemTransform;
        transform.parent = gameManager.canvasTransform;
        destroy = false;
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
           
        }

        transform.DOMove(target.transform.position, 2f).OnComplete(() => destroy = true);
        transform.DOScale(Vector3.one * 0.75f, 0.5f);



        if (destroy)
        {

            Destroy(gameObject);
        }


    }


    private void OnDestroy()
    {
        
        gameManager.gemCount += count;
       
    }
}
