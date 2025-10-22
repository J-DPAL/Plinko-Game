using UnityEngine;

public class add10points : MonoBehaviour
{
    [SerializeField] private int points = 10; 
    private GameManagement gameManager;
    [SerializeField] private DiskRemaining diskManager;

    private void Awake()
    {
        GameObject gmObject = GameObject.FindWithTag("GameManager");
        if (gmObject != null)
        {
            gameManager = gmObject.GetComponent<GameManagement>();
        }
        else
        {
            Debug.LogError("GameManagement object with tag 'GameManager' not found!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Disk"))
        {
            if (gameManager != null)
            {
                gameManager.RegisterScore(points);
                if (gameObject.tag == "ExtraLife")
                {
                    diskManager.IncreaseDisk();
                    Debug.Log("Extra disk found");
                }
            }
            else
            {
                Debug.LogWarning("GameManagement reference is missing in Bin!");
            }
        }
    }
}
