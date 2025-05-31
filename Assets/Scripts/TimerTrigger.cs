using UnityEngine;
using TMPro;

public class TimerTrigger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private float elapsedTime;
    private bool isRunning;

    void Start()
    {
        elapsedTime = 0f;
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            int milliseconds = Mathf.FloorToInt((elapsedTime * 1000) % 1000);
            timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger wurde ausgelöst von: " + other.gameObject.name);
        isRunning = false;
    } // <- Hier fehlte die geschweifte Klammer!
}
