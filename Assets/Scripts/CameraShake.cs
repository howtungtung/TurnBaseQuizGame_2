using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraShake : MonoBehaviour
{
    private CinemachineBasicMultiChannelPerlin cinemachinePerlin;
    public float shakeDuration = 0.2f;
    public float shakeIntensity = 1f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        cinemachinePerlin = GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    public void Shake()
    {
        cinemachinePerlin.m_AmplitudeGain = shakeIntensity;
        timer = shakeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            cinemachinePerlin.m_AmplitudeGain = Mathf.Lerp(0, shakeIntensity, timer / shakeDuration);
        }
    }
}
