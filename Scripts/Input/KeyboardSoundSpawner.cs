using UnityEngine;
using UnityEngine.InputSystem; // Quan trọng, để có InputAction.CallbackContext

public class KeyboardSoundSpawner : MonoBehaviour
{
    [Header("Prefab âm thanh 3D")]
    public GameObject soundPrefab;   // Prefab chứa AudioSource
    public Transform spawnPoint;     // Vị trí spawn

    // Hàm callback đúng cho Input System mới
    public void OnClickKey(InputAction.CallbackContext context)
    {
        if (context.performed) // chỉ xử lý khi action được thực hiện
        {
            Debug.Log("Nút Clicked");

            if (soundPrefab != null && spawnPoint != null)
            {
                // Spawn prefab
                GameObject soundObj = Instantiate(soundPrefab, spawnPoint.position, Quaternion.identity);

                // Lấy AudioSource trong prefab
                AudioSource audioSource = soundObj.GetComponent<AudioSource>();

                if (audioSource != null)
                {
                    audioSource.Play(); 
                    Destroy(soundObj, audioSource.clip.length); 
                }
            }
        }
    }
}
