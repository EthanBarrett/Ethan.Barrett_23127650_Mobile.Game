using UnityEngine;
using Unity.Cinemachine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake instance {  get; set; }

    public CinemachineCamera cinemachineCamera;
    public CinemachineBasicMultiChannelPerlin perlin;

    private float shakeTimer = 0f;
   
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        
      //  cinemachineCamera = GetComponent<CinemachineCamera>();
        if (cinemachineCamera == null)
            Debug.LogError("CameraShake: Assign a Cinemachine Camera in the Inspector!");

        if (perlin == null)
            Debug.LogError("CameraShake: Assign the Basic Multi-Channel Perlin in the Inspector!");



    }

    public void ShakeCamera(float intensity, float time)
    {

        if (perlin == null) return;

        perlin.AmplitudeGain = intensity;

        shakeTimer = time;
        


    }

    private void Update()
    {
        
            if(shakeTimer > 0f)
        {
            shakeTimer -= Time.deltaTime;
            if (shakeTimer <= 0f && perlin != null)
            {
                
                perlin.AmplitudeGain = 0f;
                
            }

        }





    }
}
