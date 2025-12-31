using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
     float goneTime;

    void Update()
    {
        

        goneTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(goneTime / 60);
        int seconds = Mathf.FloorToInt(goneTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);


    }
}
