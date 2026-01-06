using UnityEngine;
using Unity.Cinemachine;

public class RecolieSHake : MonoBehaviour
{
    [SerializeField] CinemachineImpulseSource screenShake;
    [SerializeField] float powerAmount = 1f;

    public void ScrreenShake()
    {
        if (screenShake == null) return;

        screenShake.GenerateImpulse(new Vector3(1f,0f,1f) *  powerAmount);
    }
}
