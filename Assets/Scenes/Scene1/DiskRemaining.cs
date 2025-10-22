using TMPro;
using UnityEngine;

public class DiskRemaining : MonoBehaviour
{

    public TextMeshProUGUI disksText; // Change Text to TextMeshProUGUI
    private int disks = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(true); // Ensure it is active
        UpdateDisksUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseDisks()
    {
        disks--;
        UpdateDisksUI();
    }

    public void IncreaseDisk()
    {
        disks++;
        UpdateDisksUI();
    }

    void UpdateDisksUI()
    {
        disksText.text = "Disks: " + disks;
    }
}
