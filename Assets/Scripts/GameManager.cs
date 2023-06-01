using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using inputManager;

public enum GameStatus { run, win}
public class GameManager : MonoBehaviour
{
    public static GameStatus gameStatus;
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private Player playerScript;
    private TouchInfo touchInfo;
    public Transform target;
    private Vector3 offset;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    public GameObject gemTransform;
    public int gemCount;
    public Image gemImage;
    public Text gemText;
    public Transform canvasTransform;
    public ParticleSystem confetti;
    public GameObject winCanvas;
    

    // Start is called before the first frame update
    void Start()
    {
        gameStatus = GameStatus.run;
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        gemText.text = gemCount.ToString();
        if(gameStatus == GameStatus.win)
        {
            confetti.Play();
            StartCoroutine(winDelay());
        }
    }
    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(offset.x + target.position.x, transform.position.y,
            offset.z + target.position.z), ref velocity, smoothTime);
    }

    IEnumerator winDelay()
    {
        yield return new WaitForSeconds(1);
        winCanvas.SetActive(true);
    }
}
