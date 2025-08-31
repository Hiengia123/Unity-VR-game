using UnityEngine;
using UnityEngine.UI;  // để bắt sự kiện Button
using System;

public class UIButtonSound : MonoBehaviour
{
    public AudioClip buttonSound;   // gán file sound trong Inspector
    private AudioSource audioSource;

    void Start()
    {
        // Tạo AudioSource 2D (không theo vị trí 3D)
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.spatialBlend = 0f; // 0 = 2D sound
    }

    // Hàm này sẽ gọi khi button được click
    public void OnScreenButtonTouched()
    {
        Debug.Log("Screen Button Touched");

        if (buttonSound != null)
        {
            audioSource.PlayOneShot(buttonSound);
        }
    }
}
