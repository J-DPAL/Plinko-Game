using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    [SerializeField] private GameObject disk;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Score scoreManager;
    [SerializeField] private DiskRemaining diskManager;
    [SerializeField] private BoardRotation boardRotation; // Reference to BoardRotation

    private void Start()
    {
        // Do not reset the disk on start
    }

    public void RegisterScore(int points)
    {
        scoreManager.AddScore(points);
        diskManager.DecreaseDisks();
        Debug.Log("Decreasing Number of Disks Remaining");
        disk.SetActive(false);

        Debug.Log("Disks Remaining: " + diskManager.disksText.text); 

        if (diskManager != null && diskManager.disksText.text != "Disks: 0")
        {
            Invoke("ResetDisk", 1f);
        }
        else
        {
            SceneManager.LoadScene("Scene2");
        }
    }

    void ResetDisk()
    {
        Debug.Log("Resetting Disk...");
        disk.SetActive(true);
        disk.transform.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, 0);
        disk.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        disk.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;

        // Use the serialized reference instead of FindObjectOfType()
        if (boardRotation != null)
        {
            boardRotation.ResetRotationLock();
        }
        else
        {
            Debug.LogWarning("BoardRotation script is not assigned in GameManagement");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (diskManager.disksText.text == "Disks: 0")
        {
            SceneManager.LoadScene("Scene2");
        }
    }
}
